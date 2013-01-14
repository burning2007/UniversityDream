using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Seedwork;
using AutoMapper;
using GF.Infrastructure.Crosscutting.Context;

namespace GF.Domain.Context.Services.AccountService
{
    public class UserService : IUserService
    {
        private char[] chapters = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',   
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };

        public void Register(User user)
        {
            if (user == null)
                throw new ArgumentNullException("account");

            if (user.Id == Guid.Empty)
                throw new ArgumentException("account.Id");

            //user.IsActive = false;
            //Random random = new Random(1);
            //var activationCode = new StringBuilder();
            //for (int i = 0; i < 6; i++)
            //    activationCode.Append(chapters[random.Next(26)-1]);

            //user.ActivationCode = activationCode.ToString();
        }

        public void ChangeAchievement(User user, Achievement achievement)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            if (achievement == null)
                throw new ArgumentNullException("achievement");

            if (achievement.Year < DateTime.Now.Year)
            {
                // throw custermized exception
				throw new AchievementException(Resource.ResourceMessage.ex_AchievementYearLessThanCurrentYear);
            }

            var achievements = user.Achievements.ToList<Achievement>();

            if (achievements != null && achievements.Count > 0)
            {
                var accountAchievement = user.Achievements.Single<Achievement>(a =>
                {
                    if (a.Year == achievement.Year && a.UserId == achievement.UserId)
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
                //accountAchievement.Id = Guid.NewGuid();
                user.Achievements.Add(accountAchievement);
            }

            //var history = new AchievementHistory(achievement);
            //user.AchievementHistories.Add(history);
            //if (user.AchievementHistories.Count<AchievementHistory>(ah => ah.Year == achievement.Year) > 3)
            //    user.LockAccount();
        }







    }
}
