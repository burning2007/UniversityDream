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

namespace GF.Application.Context
{
	public class AccountAppService : IAccountAppService
	{
		private readonly IAccountService accountService;

		public AccountAppService(IAccountService accountSrv)
		{
			accountService = accountSrv;
		}

		public void Register(Account account)
		{
			if (account == null)
				throw new ArgumentNullException("account");
			AccountRepository accountRepository = new AccountRepository();

			if (accountRepository.CheckAccountExistByName(account.AccountName))
			{
				// throw account name exists exception
				throw new AccountException(string.Format(Resource.ResourceMessage.ex_AccountExist, account.AccountName));
			}

			var accounts = accountRepository.GetFiltered(a => a.Email == account.Email);
			if (accounts.Count<Account>() > 0)
			{
				// throw email exists exception
				throw new AccountException(string.Format(Resource.ResourceMessage.ex_EmailExist, account.Email));
			}

			accounts = accountRepository.GetFiltered(a => a.IdentityCardNumber == account.IdentityCardNumber);
			if (accounts.Count<Account>() > 0)
			{
				// throw IdentityCardNumber exists exception
				throw new AccountException(string.Format(Resource.ResourceMessage.ex_IdentityCardNumberExist, account.IdentityCardNumber));
			}
			accountService.Register(account);
			accountRepository.Add(account);
			accountRepository.Commit();

			// send a email to tell use his activation code so that he can activate the account
			SendMail(account, HostSendMail.EmailCategory.ActivationCode);
		}

        public void SendActivationMail(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException("email");

            AccountRepository accountRepository = new AccountRepository();
            var account = accountRepository.GetFiltered( a => a.Email == email).SingleOrDefault<Account>();
            if (account != null && !account.IsActive)
                SendMail(account, HostSendMail.EmailCategory.ActivationCode);
            else
            {
                //TODO: throw account not exists exception
            }
        }

		public void ActivateAccount(Guid accountId, string activationCode)
		{
			if (string.IsNullOrEmpty(activationCode))
				throw new ArgumentNullException("activationCode");

			AccountRepository accountRepository = new AccountRepository();
			var account = accountRepository.Get(accountId);

			if (account != null)
				account.Activate(activationCode);
			else
			{
				// throw custermized exception
				throw new AccountException(Resource.ResourceMessage.ex_AccountIsNotExist);
			}

			accountRepository.Commit();
		}

		public bool Login(string userName, string password)
		{
			if (string.IsNullOrEmpty(userName))
				throw new ArgumentNullException("userName");

			if (string.IsNullOrEmpty(password))
				throw new ArgumentNullException("password");

			AccountRepository accountRepository = new AccountRepository();
			var account = accountRepository.Get(userName);
			if (account != null)
				return account.Login(password);
			return false;
		}

		public void ChangePassword(Guid accountId, string oldPassword, string newPassword)
		{
            if (string.IsNullOrEmpty(oldPassword))
                throw new ArgumentNullException("oldPassword");
            if (string.IsNullOrEmpty(newPassword))
                throw new ArgumentNullException("newPassword");

			AccountRepository accountRepository = new AccountRepository();
			var account = accountRepository.Get(accountId);
            if (account != null && DataCryptography.DecryptString(account.Password) == oldPassword)
			{
                account.ChangePassword(newPassword);
				accountRepository.Commit();
				// send change password tips email
				SendMail(account, HostSendMail.EmailCategory.ChangePassword);
			}
			else
			{
				// throw custermized exception
				throw new AccountException(Resource.ResourceMessage.ex_AccountIsNotExist);
			}
		}

        public void ResetPassword(Guid accountId, string email)
		{
			AccountRepository accountRepository = new AccountRepository();
			Account account = accountRepository.Get(accountId);
			if (account != null && email == account.Email)
			{
				account.ResetPassword();
				accountRepository.Commit();

				// send reset password email
				SendMail(account, HostSendMail.EmailCategory.ResetPassword);				
			}
			else
			{
				// throw custermized exception
				throw new AccountException(Resource.ResourceMessage.ex_AccountIsNotExist);
			}
		}

		public void LockAccount(Guid accountId)
		{
			AccountRepository accountRepository = new AccountRepository();
			var account = accountRepository.Get(accountId);
			if (account != null)
			{
				account.LockAccount();
				accountRepository.Commit();
			}
		}

		public void UnlockAccount(Guid accountId)
		{
			AccountRepository accountRepository = new AccountRepository();
			var account = accountRepository.Get(accountId);
			if (account != null)
			{
				account.UnlockAccount();
				accountRepository.Commit();
			}
		}

		public void ChangeAchievement(AccountDTO account_dto)
		{
			if (account_dto == null)
				throw new ArgumentNullException("account_dto");

			AccountRepository accountRepository = new AccountRepository();
			var account = accountRepository.Get(account_dto.Id);
			if (account != null)
			{
				var achievement = new Achievement(account);
				achievement.ACEENumber = account_dto.ACEENumber;
				achievement.Score = account_dto.Score;
                achievement.SpecialityType = account_dto.SpecialityType;
				achievement.Province = account_dto.Zone.Province;
                achievement.City=account_dto.Zone.City;
				accountService.ChangeAchievement(account, achievement);
				accountRepository.Commit();
			}
		}

		public void UpdateAccount(AccountDTO account_dto)
		{
			if (account_dto == null)
				throw new ArgumentNullException("account_dto");

			AccountRepository accountRepository = new AccountRepository();
			var account = Mapper.Map<Account>(account_dto);
			accountRepository.TrackEntity(account);
			accountRepository.Commit();
		}

		public void Recharge(Guid accountId, int coins)
		{
			AccountRepository accountRepository = new AccountRepository();
			var account = accountRepository.Get(accountId);
			if (account != null)
			{
				accountRepository.TrackEntity(account);
				account.Recharge(coins);
				accountRepository.Commit();
				// send recharege email
				SendMail(account, HostSendMail.EmailCategory.Recharge);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="account"></param>
		/// <param name="emailCategory"></param>
		private void SendMail(Account account,GF.Infrastructure.Crosscutting.Context.HostSendMail.EmailCategory emailCategory)
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
		private EMail CreateEmail(Account account, GF.Infrastructure.Crosscutting.Context.HostSendMail.EmailCategory emailCategory)
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
					activeMail.Subject = Resource.ResourceMessage.info_EmailSubjectActivationCode;
					activeMail.ContentBody = string.Format(Resource.ResourceMessage.info_EmailContentBodyActivationCode,account.AccountName);
					break;
				case HostSendMail.EmailCategory.ResetPassword:
					activeMail.Subject = Resource.ResourceMessage.info_EmailContentBodyResetPassword;
					activeMail.ContentBody = string.Format(Resource.ResourceMessage.info_EmailContentBodyResetPassword, account.AccountName);			
					break;
				case HostSendMail.EmailCategory.ChangePassword:
					activeMail.Subject = Resource.ResourceMessage.info_EmailSubjectChangePassword;
					activeMail.ContentBody = string.Format(Resource.ResourceMessage.info_EmailContentBodyChangePassword, account.AccountName);
					break;
				case HostSendMail.EmailCategory.Recharge:
					activeMail.Subject = Resource.ResourceMessage.info_EmailSubjectRecharge;
					activeMail.ContentBody = string.Format(Resource.ResourceMessage.info_EmailContentBodyRecharge, account.AccountName);
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

        public void CreateApplication(Domain.Context.Application application)
        {
            if (application == null)
                throw new ArgumentNullException("application");

            AccountRepository accountRepository = new AccountRepository();
            var account = accountRepository.Get(application.UserId);

            if (account != null)
            {
                var achievement = account.Achievements.ToList<Achievement>().SingleOrDefault<Achievement>( a=> a.Year.Year == DateTime.Now.Year);
                if (achievement != null)
                {
                    EnrollPlanRepository enrollPlanRepository = new EnrollPlanRepository();
                    var enrollPlans = enrollPlanRepository.GetFiltered(e => e.SpecialityId == application.SpecialityId && e.Province == achievement.Province).SingleOrDefault<EnrollPlan>();
                    if (enrollPlans != null)
                    {
                        ApplicationRepository appRepository = new ApplicationRepository();

                        var apps = appRepository.GetFiltered(app => app.Year.Year == application.Year.Year && app.Batch == application.Batch && app.ApplicationSequence == application.ApplicationSequence);
                        if (apps != null && apps.ToList<Domain.Context.Application>().Count > 0)
                        {
                            // TODO: throw existing application exception
                        }

                        appRepository.Add(application);
                        appRepository.Commit();
                    }
                    else
                    {
                        // TODO: throw no enroll plan exception
                    }
                }
            }
        }

        public void UpdateApplication(List<Domain.Context.Application> applicationList)
        {
            if (applicationList == null)
                throw new ArgumentNullException("applicationList");

            ApplicationRepository appRepository = new ApplicationRepository();
            for (int i = 0; i < applicationList.Count; i++)
            {
                // TODO: check if exists, priority low
                appRepository.Modify(applicationList[i]);
            }
            appRepository.Commit();
        }

        public void RemoveApplication(List<Domain.Context.Application> applicationList)
        {
            if (applicationList == null)
                throw new ArgumentNullException("applicationList");

            ApplicationRepository appRepository = new ApplicationRepository();
            for (int i = 0; i < applicationList.Count; i++)
            {
                appRepository.Remove(applicationList[i]);
            }
            appRepository.Commit();
        }


        
    }
}
