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
    public class SpecialityRepository : Repository<Speciality>, ISpecialityRepository
    {

        private ApplicationContext appContext;
        public SpecialityRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override void Add(Speciality speciality)
        {
            appContext.AddToSpecialities(speciality);
        }

        public Speciality Get(Guid id)
        {
            return appContext.GetSpecialityById(id).SingleOrDefault<Speciality>();
        }

        //public IList<SpecialityDTO> GetSpecialitiesByUniversityId(Guid universityId)
        //{
        //    ObjectResult<SpecialityDTO> specialities = appContext.GetSpecialityByUniversityId(universityId);
        //    return specialities.ToList<SpecialityDTO>();
        //}

        public override IList<Speciality> GetFiltered(Expression<Func<Speciality, bool>> filter)
        {
            return appContext.Specialities.Where(filter).ToList<Speciality>();
        }

        public override void TrackEntity(Speciality speciality)
        {
            if (speciality == null)
                throw new ArgumentNullException("speciality");

            context.AttachTo("Specialities", speciality);
            context.ObjectStateManager.ChangeObjectState(speciality, System.Data.EntityState.Unchanged);
        }

        public override void Merge(Speciality speciality)
        {
            if (speciality == null)
                throw new ArgumentNullException("speciality");

            context.ApplyCurrentValues<Speciality>("Specialities", speciality);
        }

        public override void Modify(Speciality speciality)
        {
            if (speciality != (Speciality)null)
            {
                appContext.AttachTo("Specialities", speciality);
                appContext.ObjectStateManager.ChangeObjectState(speciality, System.Data.EntityState.Modified);
            }
        }

        public override void Refresh(object speciality, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            appContext.Refresh(refreshMode, speciality);
        }

        public override void Remove(Speciality speciality)
        {
            if (speciality == null)
                throw new ArgumentNullException("speciality");

            appContext.DeleteObject(speciality);
        }
    }
}
