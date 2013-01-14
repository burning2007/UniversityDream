using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;
using AutoMapper;
using Microsoft.Practices.Unity;
using GF.Domain.Seedwork;
using System.Linq.Expressions;
using System.Transactions;

namespace GF.Application.Context
{
    public class AccountService : IAccountService
    {

        public void Register(AccountDTO account_dto)
        {
            if (account_dto == null)
                throw new ArgumentNullException("account_dto");

            Account account = Mapper.Map<Account>(account_dto);

            IUnityContainer container = new UnityContainer();
            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();

            var accounts = accountRepository.GetFiltered( a => a.AccountName == account.AccountName);
            if (accounts.Count<Account>() > 0)
            {
                // TODO: throw account name exists exception
            }

            accounts = accountRepository.GetFiltered(a => a.Email == account.Email);
            if (accounts.Count<Account>() > 0)
            {
                // TODO: throw email exists exception
            }

            accounts = accountRepository.GetFiltered(a => a.IdentityCardNumber == account.IdentityCardNumber);
            if (accounts.Count<Account>() > 0)
            {
                // TODO: throw IdentityCardNumber exists exception
            }

            account.GenerateNewIdentity();
            accountRepository.TrackEntity(account);
            accountRepository.Commit();
        }

        public void ChangePassword(AccountDTO account_dto, string password)
        {
            if (account_dto == null)
                throw new ArgumentNullException("account_dto");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            //Account account = Mapper.Map<Account>(account_dto);
            
            IUnityContainer container = new UnityContainer();
            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();
            Account account = accountRepository.Get(account_dto.Id);
            if (account != null)
            {
                account.ChangePassword(password);
                accountRepository.Commit();
            }
            else
            {
                // TODO: throw custermized exception
            }
        }

        public void ResetPassword(AccountDTO account_dto)
        {
            if (account_dto == null)
                throw new ArgumentNullException("account_dto");

            IUnityContainer container = new UnityContainer();
            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();
            Account account = accountRepository.Get(account_dto.Id);
            if (account != null)
            {
                account.ResetPassword();
                accountRepository.Commit();
                // TODO: send email
            }
            else
            {
                // TODO: throw custermized exception
            }
        }

        public void LockAccount(Guid accountId)
        {
            IUnityContainer container = new UnityContainer();
            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();
            Account account = accountRepository.Get(accountId);
            if (account != null)
                account.LockAccount();
            accountRepository.Commit();
        }

        public void LockAccount(AccountDTO account_dto)
        {
            if (account_dto == null)
                throw new ArgumentNullException("account_dto");

            Account account = Mapper.Map<Account>(account_dto);

            IUnityContainer container = new UnityContainer();
            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();
            accountRepository.TrackEntity(account);
            account.LockAccount();
            accountRepository.Commit();
        }

        public void UnlockAccount(Guid accountId)
        {
            IUnityContainer container = new UnityContainer();
            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();
            Account account = accountRepository.Get(accountId);
            if (account != null)
                account.UnlockAccount();
            accountRepository.Commit();
        }

        public void UnlockAccount(AccountDTO account_dto)
        {
            if (account_dto == null)
                throw new ArgumentNullException("account_dto");

            Account account = Mapper.Map<Account>(account_dto);

            IUnityContainer container = new UnityContainer();
            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();
            accountRepository.TrackEntity(account);
            account.UnlockAccount();
            accountRepository.Commit();
        }

        public void ChangeAchievement(AccountDTO account_dto)
        {
            if (account_dto == null)
                throw new ArgumentNullException("account_dto");

            var account = Mapper.Map<Account>(account_dto);
            var achievement = new Achievement(account);

            if (achievement.Year.Year < DateTime.Now.Year)
            {
                // TODO: throw custermized exception
                return;
            }

            IUnityContainer container = new UnityContainer();

            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();
            if (accountRepository.Get(achievement.AccountId) != null)
            {
                using (TransactionScope scope = new TransactionScope())
                {

                    IRepository<Achievement> achievementRepository = container.Resolve<IRepository<Achievement>>();
                    achievementRepository.TrackEntity(achievement);
                    achievementRepository.Commit();

                    var history = new AchievementHistory(achievement);
                    IRepository<AchievementHistory> archievementHistoryRepository = container.Resolve<IRepository<AchievementHistory>>();
                    archievementHistoryRepository.Add(history);
                    archievementHistoryRepository.Commit();

                    var changeTimes = archievementHistoryRepository.GetFiltered(a => a.AccountId == achievement.Id).Count<AchievementHistory>();
                    if (changeTimes > 2)
                    {
                        var accountLock = Mapper.Map<Account>(account_dto);
                        accountRepository.TrackEntity(accountLock);
                        accountLock.LockAccount();
                        accountRepository.Commit();
                    }

                    scope.Complete();
                }     
            }
        }

        public void UpdateAccount(AccountDTO account_dto)
        {
            if (account_dto == null)
                throw new ArgumentNullException("account_dto");

            IUnityContainer container = new UnityContainer();
            IRepository<Account> accountRepository = container.Resolve<IRepository<Account>>();
            var account = Mapper.Map<Account>(account_dto);
            accountRepository.TrackEntity(account);
            accountRepository.Commit();
        }
    }
}
