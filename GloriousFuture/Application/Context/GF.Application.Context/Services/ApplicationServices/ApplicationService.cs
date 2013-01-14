using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Infrastructure.Data.Context;
using GF.Domain.Context;

namespace GF.Application.Context.Services
{
    public class ApplicationService : IApplicationService
    {
        public void CreateApplication(Domain.Context.Application application)
        {
            if (application == null)
                throw new ArgumentNullException("application");

            using (UserRepository userRepository = new UserRepository())
            {
                var user = userRepository.Get(application.UserId);

                if (user != null)
                {
                    var achievement = user.Achievements.SingleOrDefault<Achievement>(a => a.Year == DateTime.Now.Year);
                    if (achievement != null)
                    {
                        //using (SpecialityEnrollPlanRepository enrollPlanRepository = new SpecialityEnrollPlanRepository())
                        //{
                        //    var enrollPlans = enrollPlanRepository.GetFiltered(e => e.SpecialityId == application.SpecialityId && e.Province == achievement.Province).SingleOrDefault<SpecialityEnrollPlan>();
                        //    if (enrollPlans != null)
                        //    {
                        using (ApplicationRepository appRepository = new ApplicationRepository())
                        {
                            var apps = appRepository.GetFiltered(app => app.Year == application.Year && app.Batch == application.Batch && app.ApplicationSequence == application.ApplicationSequence);
                            if (apps != null && apps.ToList<Domain.Context.Application>().Count > 0)
                            {
                                // throw existing application exception
                                throw new UniversityApplicationExistException(Resource.UserMessages.ex_UniversityApplicationExist);
                            }
                            appRepository.Add(application);
                            appRepository.Commit();
                        }
                        //}
                        //else
                        //{
                        //    // throw no enroll plan exception
                        //    throw new UniversityNoEnrollPlanException(Resource.ResourceMessage.ex_UnversityNoEnrollPlan);
                        //}
                        //}
                    }
                    else
                    {
                        throw new UniversityApplicationExistException(Resource.UserMessages.ex_AchievementNotExist);
                    }
                }
            }
        }

        public void UpdateApplication(List<Domain.Context.Application> applicationList)
        {
            if (applicationList == null)
                throw new ArgumentNullException("applicationList");

            using (ApplicationRepository appRepository = new ApplicationRepository())
            {
                for (int i = 0; i < applicationList.Count; i++)
                {
                    // TODO: check if exists, priority low
                    appRepository.Modify(applicationList[i]);
                }
                appRepository.Commit();
            }
        }

        public void RemoveApplication(List<Domain.Context.Application> applicationList)
        {
            if (applicationList == null)
                throw new ArgumentNullException("applicationList");

            using (ApplicationRepository appRepository = new ApplicationRepository())
            {
                for (int i = 0; i < applicationList.Count; i++)
                {
                    appRepository.Remove(applicationList[i]);
                }
                appRepository.Commit();
            }
        }

        public IList<ApplicationsDTO> GetApplicationByUserId(Guid userId)
        {
            using (ApplicationRepository appRepository = new ApplicationRepository())
            {
                return appRepository.GetByUserId(userId);
            }
        }


        //public IList<ApplicationProvinceStatisticDTO> GetApplicationProvinceStatistic(Guid specialityId, string province)
        //{
        //    using (ApplicationRepository appRepository = new ApplicationRepository())
        //    {
        //        return appRepository.GetApplicationProvinceStatistic(specialityId, province);
        //    }
        //}

        //public IList<ApplicationUserStatisticDTO> GetApplicationUserStatistic(Guid specialityId, string province)
        //{
        //    using (ApplicationRepository appRepository = new ApplicationRepository())
        //    {
        //        return appRepository.GetApplicationUserStatistic(specialityId, province);
        //    }
        //}

        //public IList<ApplicationsDTO> GetLatestApplications()
        //{
        //    using (ApplicationRepository appRepository = new ApplicationRepository())
        //    {
        //        return appRepository.GetLatestApplications();
        //    }
        //}

        //public IList<ApplicationScoreRankStatisticDTO> GetApplicationScoreRankStatistic(Guid specialityId, string province)
        //{
        //    using (ApplicationRepository appRepository = new ApplicationRepository())
        //    {
        //        return appRepository.GetApplicationScoreRankStatistic(specialityId, province);
        //    }
        //}

        //public IList<ApplicationSequenceProvinceStatisticDTO> GetApplicationSequenceProvinceStatistic(Guid specialityId, string province, int applicationSequence)
        //{
        //    using (ApplicationRepository appRepository = new ApplicationRepository())
        //    {
        //        return appRepository.GetApplicationSequenceProvinceStatistic(specialityId, province, applicationSequence);
        //    }
        //}

        //public IList<ApplicationSequenceScoreRankStatisticDTO> GetApplicationSequenceScoreRankStatistic(Guid specialityId, string province, int applicationSequence)
        //{
        //    using (ApplicationRepository appRepository = new ApplicationRepository())
        //    {
        //        return appRepository.GetApplicationSequenceScoreRankStatistic(specialityId, province, applicationSequence);
        //    }
        //}

        //public IList<TopPopularSpecialitiesDTO> GetTopPopularSpecialities()
        //{
        //    using (ApplicationRepository appRepository = new ApplicationRepository())
        //    {
        //        return appRepository.GetTopPopularSpecialities();
        //    }
        //}
    }
}
