using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Seedwork;
using AutoMapper;
using GF.Infrastructure.Crosscutting.Context;

namespace GF.Domain.Context.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private char[] chapters = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',   
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };

        public void Register(Account account)
        {
            if (account == null)
                throw new ArgumentNullException("account");

            if (account.Id == Guid.Empty)
                throw new ArgumentException("account.Id");

            account.IsActive = false;
            Random random = new Random(1);
            var activationCode = new StringBuilder();
            for (int i = 0; i < 6; i++)
                activationCode.Append(chapters[random.Next(26)-1]);

            account.ActivationCode = activationCode.ToString();
        }

        public void ChangeAchievement(Account account, Achievement achievement)
        {
            if (account == null)
                throw new ArgumentNullException("account");

            if (achievement == null)
                throw new ArgumentNullException("achievement");

            if (achievement.Year.Year < DateTime.Now.Year)
            {
                // throw custermized exception
				throw new AchievementException(Resource.ResourceMessage.ex_AchievementYearLessThanCurrentYear);
                return;
            }

            var achievements = account.Achievements.ToList<Achievement>();

            if (achievements != null && achievements.Count > 0)
            {
                var accountAchievement = account.Achievements.Single<Achievement>(a =>
                {
                    if (a.Year == achievement.Year && a.AccountId == achievement.AccountId)
                        return true;
                    return false;
                });

                if (accountAchievement != null)
                {
                    achievement.Id = accountAchievement.Id;
                    accountAchievement = Mapper.Map<Achievement>(achievement);
                }              
            }
            else
            {
                var accountAchievement = Mapper.Map<Achievement>(achievement);
                accountAchievement.Id = Guid.NewGuid();
                account.Achievements.Add(accountAchievement);
            }

            var history = new AchievementHistory(achievement);
            account.AchievementHistories.Add(history);
            if (account.AchievementHistories.Count<AchievementHistory>(ah => ah.Year == achievement.Year) > 3)
                account.LockAccount();
        }







    }
}
