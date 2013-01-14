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
    public class UniversityAcceptanceStatisticRepository : Repository<UniversityAcceptanceStatistic>
    {
        private ApplicationContext appContext;

        public UniversityAcceptanceStatisticRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override void Add(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            appContext.AddToUniversityAcceptanceStatistics(universityAcceptanceStatistic);
        }

        public override IList<UniversityAcceptanceStatistic> GetFiltered(Expression<Func<UniversityAcceptanceStatistic, bool>> filter)
        {
            return appContext.UniversityAcceptanceStatistics.Where(filter).ToList<UniversityAcceptanceStatistic>();
        }

        public override void TrackEntity(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            if (universityAcceptanceStatistic == null)
                throw new ArgumentNullException("universityAcceptanceStatistic");

            context.AttachTo("UniversityAcceptanceStatistics", universityAcceptanceStatistic);
            context.ObjectStateManager.ChangeObjectState(universityAcceptanceStatistic, System.Data.EntityState.Unchanged);
        }

        public override void Merge(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            context.ApplyCurrentValues<UniversityAcceptanceStatistic>("UniversityAcceptanceStatistics", universityAcceptanceStatistic);
        }

        public override void Modify(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            if (universityAcceptanceStatistic != (UniversityAcceptanceStatistic)null)
            {
                appContext.AttachTo("UniversityAcceptanceStatistics", universityAcceptanceStatistic);
                appContext.ObjectStateManager.ChangeObjectState(universityAcceptanceStatistic, System.Data.EntityState.Modified);
            }
        }

        public override void Remove(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            if (universityAcceptanceStatistic == null)
                throw new ArgumentNullException("universityAcceptanceStatistic");

            appContext.DeleteObject(universityAcceptanceStatistic);
        }

        public override void Refresh(object universityAcceptanceStatistic, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            appContext.Refresh(refreshMode, universityAcceptanceStatistic);
        }
    }
}
