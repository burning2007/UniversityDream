using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq.Expressions;

namespace GF.Domain.Seedwork
{
    public interface IRepository<TEntity> : IDisposable, IUnitOfWork
        where TEntity : EntityObject
    {

        /// <summary>
        /// Add entity into repository
        /// </summary>
        /// <param name="entity">entity to add to repository</param>
        void Add(TEntity entity);

        /// <summary>
        /// Delete entity 
        /// </summary>
        /// <param name="entity">entity to delete</param>
        void Remove(TEntity entity);

        /// <summary>
        /// Set entity as modified
        /// </summary>
        /// <param name="entity">entity to modify</param>
        void Modify(TEntity entity);

        /// <summary>
        ///Track entity into this repository, really in UnitOfWork. 
        ///In EF this can be done with Attach and with Update in NH
        /// </summary>
        /// <param name="entity">entity to attach</param>
        void TrackEntity(TEntity entity);

        /// <summary>
        /// Sets modified entity into the repository. 
        /// When calling Commit() method in UnitOfWork 
        /// these changes will be saved into the storage
        /// </summary>
        /// <param name="persisted">The entitySetName</param>
        /// <param name="current">The current entity</param>
        void Merge(TEntity current);

        /// <summary>
        /// Get element by entity key
        /// </summary>
        /// <param name="id">Entity key value</param>
        /// <returns></returns>
        //TEntity Get<TProperty>(TProperty id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="refreshMode"></param>
        void Refresh(Object entity, RefreshMode refreshMode = RefreshMode.StoreWins);

        /// <summary>
        /// Get all elements of type TEntity in repository
        /// </summary>
        /// <returns>List of selected elements</returns>
        IList<TEntity> GetAll();

        /// <summary>
        /// Get all elements of type TEntity that matching a
        /// Specification <paramref name="specification"/>
        /// </summary>
        /// <param name="specification">Specification that result meet</param>
        /// <returns></returns>
        IList<TEntity> AllMatching(ISpecification<TEntity> specification);

        /// <summary>
        /// Get all elements of type TEntity in repository
        /// </summary>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageCount">Number of elements in each page</param>
        /// <param name="orderByExpression">Order by expression for this query</param>
        /// <param name="ascending">Specify if order is ascending</param>
        /// <returns>List of selected elements</returns>
        IList<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, out int totalPagesCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending, Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Get  elements of type TEntity in repository
        /// </summary>
        /// <param name="filter">Filter that each element do match</param>
        /// <returns>List of selected elements</returns>
        IList<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter);

    }
}
