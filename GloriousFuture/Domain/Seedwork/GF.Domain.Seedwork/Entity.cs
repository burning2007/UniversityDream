using System;
using System.Data.Objects.DataClasses;

namespace GF.Domain.Seedwork
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract class Entity<TKeyProperty> : EntityObject
    {
        #region Members

        int? _requestedHashCode;
        TKeyProperty _Id;

        #endregion

        #region Properties

        /// <summary>
        /// Get the persisten object identifier
        /// </summary>
        public virtual TKeyProperty Id 
        {
            get
            {
                return _Id;
            }
            protected set
            {
                //if (_Id != value)
                    _Id = value;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Check if this entity is transient, ie, without identity at this moment
        /// </summary>
        /// <returns>True if entity is transient, else false</returns>
        private bool IsTransient()
        {
            return this.Id == Guid.Empty;
        }

        /// <summary>
        /// Generate identity for this entity
        /// </summary>
        private void GenerateNewIdentity()
        {
            if (IsTransient())
                this.Id = Guid.NewGuid();
        }

        /// <summary>
        /// Change current identity for a new non transient identity
        /// </summary>
        /// <param name="identity">the new identity</param>
        private void ChangeCurrentIdentity(Guid identity)
        {
            if ( identity != Guid.Empty)
                this.Id = identity;
        }

        #endregion

        #region Overrides Methods

        /// <summary>
        /// <see cref="M:System.Object.Equals"/>
        /// </summary>
        /// <param name="obj"><see cref="M:System.Object.Equals"/></param>
        /// <returns><see cref="M:System.Object.Equals"/></returns>
        //public override bool Equals(object obj)
        //{
        //    if (obj == null || !(obj is Entity))
        //        return false;

        //    if (Object.ReferenceEquals(this, obj))
        //        return true;

        //    Entity entity = (Entity)obj;

        //    if (entity.IsTransient() || this.IsTransient())
        //        return false;
        //    else
        //        return entity.Id == this.Id;
        //}

        /// <summary>
        /// <see cref="M:System.Object.GetHashCode"/>
        /// </summary>
        /// <returns><see cref="M:System.Object.GetHashCode"/></returns>
        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31;

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();

        }

        //public static bool operator ==(Entity left, Entity right)
        //{
        //    if (Object.Equals(left, null))
        //        return (Object.Equals(right, null)) ? true : false;
        //    else
        //        return left.Equals(right);
        //}

        //public static bool operator !=(Entity left, Entity right)
        //{
        //    return !(left == right);
        //}

        #endregion
    }
}
