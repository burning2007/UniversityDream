using System;
using System.Linq;
using GF.Infrastructure.Data.Seedwork;
using GF.Domain.Context;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Data.Objects;

namespace GF.Infrastructure.Data.Context
{
    public class UniversityRepository : Repository<University>, IUniversityRepository
    {

        private ApplicationContext appContext;
        public UniversityRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override void Add(University university)
        {
            appContext.AddToUniversities(university);
        }

        public University Get(Guid universityId)
        {
            ObjectResult<University> universities = appContext.GetUniversityById(universityId);
            return universities.SingleOrDefault<University>();
        }

        public override IList<University> GetFiltered(Expression<Func<University, bool>> filter)
        {
            return appContext.Universities.Where(filter).ToList<University>();
        }

        public override void TrackEntity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university");

            context.AttachTo("Universities", university);
            context.ObjectStateManager.ChangeObjectState(university, System.Data.EntityState.Unchanged);
        }

        public override void Merge(University university)
        {
            context.ApplyCurrentValues<University>("Universities", university);
        }

        public override void Modify(University university)
        {
            if (university != (University)null)
            {
                appContext.AttachTo("Universities", university);
                appContext.ObjectStateManager.ChangeObjectState(university, System.Data.EntityState.Modified);
            }
        }

        public override void Refresh(object university, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            appContext.Refresh(refreshMode, university);
        }

        public override void Remove(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university");

            appContext.DeleteObject(university);
        }

        public override IList<University> GetAll()
        {
            return appContext.Universities.ToList<University>();
        }


        public override IList<University> GetPaged<KProperty>(int pageIndex, int pageCount, out int totalPagesCount, Expression<Func<University, KProperty>> orderByExpression, bool ascending, Expression<Func<University, bool>> filter = null)
        {
            if (ascending)
            {
                if (filter != null)
                {
                    totalPagesCount = (int)Math.Ceiling(Convert.ToDouble(appContext.Universities.Where(filter).Count<University>()) / pageCount);
                    return appContext.Universities.Include("Region").Where(filter).OrderBy(orderByExpression)
                            .Skip(pageCount * pageIndex)
                            .Take(pageCount).ToList<University>();
                }
                else
                {
                    totalPagesCount = (int)Math.Ceiling(Convert.ToDouble(appContext.Universities.Count<University>()) / pageCount);
                    return appContext.Universities.Include("Region").OrderBy(orderByExpression)
                            .Skip(pageCount * pageIndex)
                            .Take(pageCount).ToList<University>();
                }
            }
            else
            {
                if (filter != null)
                {
                    totalPagesCount = (int)Math.Ceiling(Convert.ToDouble(appContext.Universities.Where(filter).Count<University>()) / pageCount);
                    return appContext.Universities.Include("Region").Where(filter).OrderByDescending(orderByExpression)
                            .Skip(pageCount * pageIndex)
                            .Take(pageCount).ToList<University>();
                }
                else
                {
                    totalPagesCount = (int)Math.Ceiling(Convert.ToDouble(appContext.Universities.Count<University>()) / pageCount);
                    return appContext.Universities.Include("Region").OrderByDescending(orderByExpression)
                            .Skip(pageCount * pageIndex)
                            .Take(pageCount).ToList<University>();
                }
            }
        }

    }
}
