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
    public class UniversityEnrollPlanRepository : Repository<UniversityEnrollPlan>
    {
        private ApplicationContext appContext;
        public UniversityEnrollPlanRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override void Add(UniversityEnrollPlan enrollPlan)
        {
            appContext.AddToUniversityEnrollPlans(enrollPlan);
        }

        //public override UniversityEnrollPlan Get(Guid id)
        //{
        //    ObjectResult<UniversityEnrollPlan> enrollPlan = appContext.GetUniversityEnrollPlansByUniversityId(id);
        //    return enrollPlan.SingleOrDefault<UniversityEnrollPlan>();
        //}

        public override IList<UniversityEnrollPlan> GetFiltered(Expression<Func<UniversityEnrollPlan, bool>> filter)
        {
            return appContext.UniversityEnrollPlans.Where(filter).ToList<UniversityEnrollPlan>();
        }

        public override void TrackEntity(UniversityEnrollPlan enrollPlan)
        {
            if (enrollPlan == null)
                throw new ArgumentNullException("enrollPlan");

            context.AttachTo("EnrollPlans", enrollPlan);
            context.ObjectStateManager.ChangeObjectState(enrollPlan, System.Data.EntityState.Unchanged);
        }

        public override void Merge(UniversityEnrollPlan enrollPlan)
        {
            context.ApplyCurrentValues<UniversityEnrollPlan>("EnrollPlans", enrollPlan);
        }

        public override void Modify(UniversityEnrollPlan enrollPlan)
        {
            if (enrollPlan != (UniversityEnrollPlan)null)
            {
                appContext.AttachTo("EnrollPlans", enrollPlan);
                appContext.ObjectStateManager.ChangeObjectState(enrollPlan, System.Data.EntityState.Modified);
            }
        }

        public override void Refresh(object enrollPlan, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            appContext.Refresh(refreshMode, enrollPlan);
        }

        public override void Remove(UniversityEnrollPlan enrollPlan)
        {
            if (enrollPlan == null)
                throw new ArgumentNullException("enrollPlan");

            appContext.DeleteObject(enrollPlan);
        }

        


    }
}
