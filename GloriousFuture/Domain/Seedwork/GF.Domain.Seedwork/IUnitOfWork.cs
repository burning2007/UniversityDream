using System;

namespace GF.Domain.Seedwork
{
    public interface IUnitOfWork
        :IDisposable
    {
        /// <summary>
        /// Commit all changes made in a container.
        /// </summary>
        ///<remarks>
        /// If the entity have fixed properties and any optimistic concurrency problem exists,  
        /// then an exception is thrown
        ///</remarks>
        void Commit();


        /// <summary>
        /// Rollback tracked changes. See references of UnitOfWork pattern
        /// </summary>
        /// <param name="entity">entity to rollback</param>
        void RollbackChanges(Object entity);

    }
}
