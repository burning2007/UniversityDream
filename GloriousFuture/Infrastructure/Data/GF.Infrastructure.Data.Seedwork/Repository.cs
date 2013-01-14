using System;
using System.Collections.Generic;
using GF.Domain.Seedwork;
using System.Data.Objects;
using System.Linq;
using System.Data.Objects.DataClasses;
using System.Linq.Expressions;

namespace GF.Infrastructure.Data.Seedwork
{

    /// <summary>
    /// Repository base class
    /// </summary>
    /// <typeparam name="TEntity">The type of underlying entity in this repository</typeparam>
    public class Repository<TEntity> :IRepository<TEntity>
        where TEntity:EntityObject
    {

        #region Members

        protected ObjectContext context = null;

        #endregion

        #region Constructor 

        public Repository()
        {
        }

        #endregion

        #region IRepository Members


        public virtual void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(TEntity entity)
        {
            if (entity != (TEntity)null)
            {
                context.DeleteObject(entity);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public virtual void Modify(TEntity entity)
        {
            if (entity != (TEntity)null)
            {
                context.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public virtual void TrackEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual IList<TEntity> GetAll()
        {
            return GetSet().ToList<TEntity>();
        }

        public virtual IList<TEntity> AllMatching(ISpecification<TEntity> specification)
        {
            return GetSet().Where(specification.SatisfiedBy()).ToList<TEntity>();
        }

        public virtual IList<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, out int totalPagesCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending, Expression<Func<TEntity, bool>> filter = null)
        {
            var set = GetSet();

            if (ascending)
            {
                if (filter != null)
                {
                    totalPagesCount = set.Where(filter).Count<TEntity>() / pageCount;
                    return set.Where(filter).OrderBy(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount).ToList<TEntity>();
                }
                else
                {
                    totalPagesCount = set.Count<TEntity>() / pageCount;
                    return set.OrderBy(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount).ToList<TEntity>();
                }
            }
            else
            {
                if (filter != null)
                {
                    totalPagesCount = set.Where(filter).Count<TEntity>() / pageCount;
                    return set.Where(filter).OrderByDescending(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount).ToList<TEntity>();
                }
                else
                {
                    totalPagesCount = set.Count<TEntity>() / pageCount;
                    return set.OrderByDescending(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount).ToList<TEntity>();
                }
            }
        }

        public virtual IList<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter)
        {
            return GetSet().Where(filter).ToList<TEntity>();
        }


        public virtual void Merge(TEntity current)
        {
            throw new NotImplementedException();
        }

        public virtual void Refresh(Object entity, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            context.Refresh(refreshMode, entity);
        }


        #endregion

        #region IDisposable Members


        public virtual void Dispose()
        {
            if (context != null)
                context.Dispose();
        }

        #endregion

        #region Private Methods

        private IObjectSet<TEntity> GetSet()
        {
            return context.CreateObjectSet<TEntity>();
        }
        #endregion

        #region IUnitOfWork

        public void Commit()
        {
            context.SaveChanges(SaveOptions.DetectChangesBeforeSave | SaveOptions.AcceptAllChangesAfterSave);
        }

        public void RollbackChanges(object entity)
        {
            Refresh(entity);
        }

        #endregion


        

    }
}
