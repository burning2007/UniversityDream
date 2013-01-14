using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Infrastructure.Data.Seedwork;
using GF.Domain.Context;
using System.Linq.Expressions;
using System.Data.Objects;

namespace GF.Infrastructure.Data.Context
{
    public class ApplicationRepository : Repository<Application>, IApplicationRepository
    {
        private ApplicationContext appContext;

        public ApplicationRepository():base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override void Add(Application application)
        {
            appContext.AddToApplications(application);
        }

        public Application Get(Guid id)
        {
            ObjectResult<Application> applications = appContext.GetApplicationById(id);
            return applications.SingleOrDefault<Application>();
        }

        public IList<ApplicationsDTO> GetByUserId(Guid userId)
        {
            var applications = appContext.GetApplicationsByUserId(userId);
            return applications.ToList<ApplicationsDTO>();
        }

        public override IList<Application> GetFiltered(Expression<Func<Application, bool>> filter)
        {
            return appContext.Applications.Where(filter).ToList<Application>();
        }

        public override void TrackEntity(Application application)
        {
            if (application == null)
                throw new ArgumentNullException("application");

            context.AttachTo("Applications", application);
            context.ObjectStateManager.ChangeObjectState(application, System.Data.EntityState.Unchanged);
        }

        public override void Merge(Application application)
        {
            if (application == null)
                throw new ArgumentNullException("application");

            context.ApplyCurrentValues<Application>("Applications", application);
        }


        public override void Remove(Application application)
        {
            if (application == null)
                throw new ArgumentNullException("application");

            appContext.DeleteObject(application);
        }

        public override void Refresh(object application, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            appContext.Refresh(refreshMode, application);
        }


        //public IList<ApplicationProvinceStatisticDTO> GetApplicationProvinceStatistic(Guid specialityId, string province)
        //{
        //    if (string.IsNullOrEmpty(province))
        //        throw new ArgumentNullException("province");


        //    var apps = appContext.GetApplicationProvinceStatistic(specialityId, province);
        //    return apps.ToList<ApplicationProvinceStatisticDTO>();
        //}

        //public IList<ApplicationUserStatisticDTO> GetApplicationUserStatistic(Guid specialityId, string province)
        //{
        //    if (string.IsNullOrEmpty(province))
        //        throw new ArgumentNullException("province");

        //    var apps = appContext.GetApplicationUserStatistic(specialityId, province);
        //    return apps.ToList<ApplicationUserStatisticDTO>();
        //}

        //public IList<ApplicationsDTO> GetLatestApplications()
        //{
        //    var apps = appContext.GetLatestApplications();
        //    return apps.ToList<ApplicationsDTO>();
        //}


        //public IList<ApplicationScoreRankStatisticDTO> GetApplicationScoreRankStatistic(Guid specialityId, string province)
        //{
        //    if (string.IsNullOrEmpty(province))
        //        throw new ArgumentNullException("province");

        //    var apps = appContext.GetApplicationScoreRankStatistic(specialityId, province);
        //    return apps.ToList<ApplicationScoreRankStatisticDTO>();
        //}

        //public IList<ApplicationSequenceProvinceStatisticDTO> GetApplicationSequenceProvinceStatistic(Guid specialityId, string province, int applicationSequence)
        //{
        //    if (string.IsNullOrEmpty(province))
        //        throw new ArgumentNullException("province");

        //    var apps = appContext.GetApplicationSequenceProvinceStatistic(specialityId, province, applicationSequence);
        //    return apps.ToList<ApplicationSequenceProvinceStatisticDTO>();
        //}

        //public IList<ApplicationSequenceScoreRankStatisticDTO> GetApplicationSequenceScoreRankStatistic(Guid specialityId, string province, int applicationSequence)
        //{
        //    if (string.IsNullOrEmpty(province))
        //        throw new ArgumentNullException("province");

        //    var apps = appContext.GetApplicationSequenceScoreRankStatistic(specialityId, province, applicationSequence);
        //    return apps.ToList<ApplicationSequenceScoreRankStatisticDTO>();
        //}

        //public IList<TopPopularSpecialitiesDTO> GetTopPopularSpecialities()
        //{
        //    var apps = appContext.GetTopPopularSpecialities();
        //    return apps.ToList<TopPopularSpecialitiesDTO>();
        //}

    }
}
