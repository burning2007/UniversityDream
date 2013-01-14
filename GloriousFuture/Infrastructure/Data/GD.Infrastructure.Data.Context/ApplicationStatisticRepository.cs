using System.Collections.Generic;
using System.Linq;
using GF.Infrastructure.Data.Seedwork;
using GF.Domain.Context;
using System.Data.Objects;
using System.Linq.Expressions;
using System;

namespace GF.Infrastructure.Data.Context
{
    public class ApplicationStatisticRepository : Repository<ApplicationStatistic>, IApplicationStatisticRepository
    {
        private ApplicationContext appContext;

        public ApplicationStatisticRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        //public IList<ApplicationSequenceProvinceStatisticDTO> GetApplicationSequenceProvinceStatistic(Guid specialityId, string province = "上海市", int applicationSequence = 1)
        //{
        //    var app_dto = appContext.GetApplicationSequenceProvinceStatistic(specialityId, province, applicationSequence);
        //    return app_dto.ToList<ApplicationSequenceProvinceStatisticDTO>();
        //}

        public override IList<ApplicationStatistic> GetFiltered(Expression<Func<ApplicationStatistic, bool>> filter)
        {
            return appContext.ApplicationStatistics.Where(filter).ToList<ApplicationStatistic>();
        }

        public override void Refresh(object applicationStatistic, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            appContext.Refresh(refreshMode, applicationStatistic);
        }

        public override void Add(ApplicationStatistic applicationStatistic)
        {
            appContext.AddToApplicationStatistics(applicationStatistic);
        }

        public override void Merge(ApplicationStatistic applicationStatistic)
        {
            context.ApplyCurrentValues<ApplicationStatistic>("ApplicationStatistics", applicationStatistic);
        }

        public override void Modify(ApplicationStatistic applicationStatistic)
        {
            context.ApplyCurrentValues<ApplicationStatistic>("ApplicationStatistics", applicationStatistic);
        }

        public override void TrackEntity(ApplicationStatistic applicationStatistic)
        {
            if (applicationStatistic == null)
                throw new ArgumentNullException("applicationStatistic");

            context.AttachTo("ApplicationStatistics", applicationStatistic);
            context.ObjectStateManager.ChangeObjectState(applicationStatistic, System.Data.EntityState.Unchanged);
        }

       
       
    }
}
