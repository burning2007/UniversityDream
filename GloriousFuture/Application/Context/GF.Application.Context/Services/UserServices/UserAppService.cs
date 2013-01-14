using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;
using AutoMapper;
using GF.Domain.Seedwork;
using System.Linq.Expressions;
using System.Transactions;
using GF.Domain.Context.Services.AccountService;
using GF.Infrastructure.Data.Context;
using GF.Infrastructure.Crosscutting.Context;

namespace GF.Application.Context.Services
{
	public class UserAppService : IUserAppService
	{
		private readonly IUserService userService = new UserService();

		public UserAppService()
		{
		}

		public void Register(User user)
		{
			if (user == null)
                throw new ArgumentNullException("user");

            using (UserRepository userRepository = new UserRepository())
            {
                if (userRepository.CheckAccountExistByName(user.UserName))
                {
                    // throw account name exists exception
                    throw new AccountIsExistException(string.Format(Resource.UserMessages.ex_AccountExist, user.UserName));
                }

                var accounts = userRepository.GetFiltered(a => a.Email == user.Email);
                if (accounts.Count<User>() > 0)
                {
                    // throw email exists exception
                    throw new AccountEmailExistException(string.Format(Resource.UserMessages.ex_EmailExist, user.Email));
                }

                userRepository.Add(user);
                userRepository.Commit();
            }
		}

		public bool Login(string userName, string password)
		{
			if (string.IsNullOrWhiteSpace(userName))
				throw new ArgumentNullException("userName");

			if (string.IsNullOrWhiteSpace(password))
				throw new ArgumentNullException("password");

            using (UserRepository userRepository = new UserRepository())
            {
                var account = userRepository.Get(userName);
                if (account != null)
                    return account.Login(password);
                return false;
            }
		}

        public void ChangePassword(string userName, string oldPassword, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(oldPassword))
                throw new ArgumentNullException("oldPassword");
            if (string.IsNullOrWhiteSpace(newPassword))
                throw new ArgumentNullException("newPassword");

            using (UserRepository userRepository = new UserRepository())
            {
                var account = userRepository.Get(userName);
                if (account != null && DataCryptography.DecryptString(account.Password) == oldPassword)
                {
                    account.ChangePassword(newPassword);
                    userRepository.Commit();
                    // send change password tips email
                    SendMail(account, HostSendMail.EmailCategory.ChangePassword);
                }
                else
                {
                    // throw custermized exception
                    throw new UserNotExistException(Resource.UserMessages.ex_AccountIsNotExist);
                }
            }
        }

        public void ResetPassword(string userName, string email)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userName);
                if (user != null && email == user.Email)
                {
                    user.ResetPassword();
                    userRepository.Commit();
                    // send reset password email
                    SendMail(user, HostSendMail.EmailCategory.ResetPassword);
                }
                else
                {
                    // throw custermized exception
                    throw new UserNotExistException(Resource.UserMessages.ex_AccountIsNotExist);
                }
            }
        }

        public void LockAccount(string userName)
		{
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userName);
                if (user != null)
                {
                    user.LockAccount();
                    userRepository.Commit();
                }
            }
		}

        public void UnlockAccount(string userName)
		{
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userName);
                if (user != null)
                {
                    user.UnlockAccount();
                    userRepository.Commit();
                }
            }
		}

        public void Recharge(string userName, int coins)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userName);
                if (user != null)
                {
                    // TODO: call 3rd party recharge request 

                    userRepository.TrackEntity(user);
                    user.Recharge(coins);
                    var rechargeRecord = new RechargeRecord { Coins = coins, RechargeTime = DateTime.Now, UserId = user.Id };
                    user.RechargeRecords.Add(rechargeRecord);
                    userRepository.Commit();
                    // send recharege email
                    SendMail(user, HostSendMail.EmailCategory.Recharge);
                }
            }
        }        

		/// <summary>
		/// 
		/// </summary>
		/// <param name="account"></param>
		/// <param name="emailCategory"></param>
		private void SendMail(User account,GF.Infrastructure.Crosscutting.Context.HostSendMail.EmailCategory emailCategory)
		{
			EMail emailModel = CreateEmail(account, emailCategory);
			HostSendMail hostSendMail = HostSendMail.CreateHostSendMail();
			hostSendMail.SendMail(emailModel);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="account"></param>
		/// <returns></returns>
		private EMail CreateEmail(User account, GF.Infrastructure.Crosscutting.Context.HostSendMail.EmailCategory emailCategory)
		{
			EMail activeMail = EMail.CreateEMail();

			activeMail.UserName = "csh20121219";
			activeMail.Password = "zcl19830713";
			activeMail.MailFrom = "csh20121219@163.com";
			activeMail.DisplaySenderName = "GloriousFuture";

			activeMail.MailToList.Add(account.Email);
			activeMail.MailCCList = new List<string>();
			activeMail.MailBCCList = new List<string>();
			activeMail.Encoding = Encoding.UTF8;

			switch (emailCategory)
			{ 
				case HostSendMail.EmailCategory.ActivationCode:
					activeMail.Subject = Resource.UserMessages.info_EmailSubjectActivationCode;
					activeMail.ContentBody = string.Format(Resource.UserMessages.info_EmailContentBodyActivationCode,account.UserName);
					break;
				case HostSendMail.EmailCategory.ResetPassword:
					activeMail.Subject = Resource.UserMessages.info_EmailContentBodyResetPassword;
					activeMail.ContentBody = string.Format(Resource.UserMessages.info_EmailContentBodyResetPassword, account.UserName);			
					break;
				case HostSendMail.EmailCategory.ChangePassword:
					activeMail.Subject = Resource.UserMessages.info_EmailSubjectChangePassword;
					activeMail.ContentBody = string.Format(Resource.UserMessages.info_EmailContentBodyChangePassword, account.UserName);
					break;
				case HostSendMail.EmailCategory.Recharge:
					activeMail.Subject = Resource.UserMessages.info_EmailSubjectRecharge;
					activeMail.ContentBody = string.Format(Resource.UserMessages.info_EmailContentBodyRecharge, account.UserName);
					break;
				default:
					break;

			}


			
			activeMail.Host = "smtp.163.com";
			//mailEntity.Port = 465;
			activeMail.TimeOut = 999999;
			activeMail.Encoding = Encoding.UTF8; //Encoding.GetEncoding("GB2312"); ;
			activeMail.IsBodyHtml = true;
			activeMail.EnableSSL = true;

			return activeMail;
		}


        public User GetUser(string userName)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userName);
                user.Achievements.Load();
                return user;
            }
        }

        public void ChangeAchievement(Achievement achievement)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(achievement.UserId);
                if (user != null)
                {
                    var _achievement = user.Achievements.SingleOrDefault<Achievement>(a => a.Year == DateTime.Now.Year && a.UserId == user.Id);
                    if (_achievement != null)
                    {
                        var id = _achievement.Id;
                        _achievement = Mapper.Map<Achievement>(achievement);
                        _achievement.Id = id;
                    }
                    else
                        user.Achievements.Add(achievement);

                    userRepository.Commit();
                }
            }
        }

        public void ChangeIDCard(string userName, string idCardNo, string chineseName)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userName);
                if (user != null)
                {
                    user.ChangeIDCard(idCardNo, chineseName);
                    userRepository.Commit();
                }
            }
        }

        public bool ValidateIDCard(string userName, string idCardNo, string chineseName)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userName);
                if (user != null && user.IDCardNo == idCardNo && user.ChineseName == chineseName)
                {
                    // TODO: call 3rd party id card validation
                    if (true)
                    {
                        user.IDCards.Add(new IDCard { ChineseName = chineseName, IDCardNo = idCardNo, UserId = user.Id });
                        user.IsIDCardValid = true;
                        userRepository.Commit();
                        return true;
                    }
                }
                return false;
            }
        }

        public void ChangeUser(string userName, string qq, bool gender)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(userName);
                if (user != null)
                {
                    user.QQ = qq;
                    user.Gender = gender;
                    userRepository.Commit();
                }
            }
        }

        public Role GetRole(string roleName)
        {
            using (RoleRepository roleRepository = new RoleRepository())
            {
                return roleRepository.Get(roleName);
            }
        }
    }
}
