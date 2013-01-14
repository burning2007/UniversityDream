﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;
using GF.Infrastructure.Data.Context;
using System.Linq.Expressions;

namespace GF.Application.Context.Services
{
    public class UniversityAppService : IUniversityAppService
    {

        public void PublishEnrollPlan(UniversityEnrollPlan enrollPlan)
        {
            if (enrollPlan == null)
                throw new ArgumentNullException("enrollPlan");

            using (UniversityEnrollPlanRepository enrollPlanRepository = new UniversityEnrollPlanRepository())
            {
                var ens = enrollPlanRepository.GetFiltered(e => e.Year == enrollPlan.Year && e.ProvinceId == enrollPlan.ProvinceId && e.UniversityId == enrollPlan.UniversityId);
                if (ens != null)
                {
                    // TODO: throw existing exception
                }
                enrollPlanRepository.Add(enrollPlan);
                enrollPlanRepository.Commit();
            }
        }

        public void UpdateEnrollPlan(UniversityEnrollPlan enrollPlan)
        {
            if (enrollPlan == null)
                throw new ArgumentNullException("enrollPlan");

            using (UniversityEnrollPlanRepository enrollPlanRepository = new UniversityEnrollPlanRepository())
            {
                //var enroll = enrollPlanRepository.Get(enrollPlan.Id);
                //if (enroll == null)
                //{
                //    // TODO: throw not existing exception
                //}
                //enrollPlanRepository.Modify(enrollPlan);
                //enrollPlanRepository.Commit();
            }
        }

        public void RemoveEnrollPlan(Guid enrollPlanId)
        {
            using (UniversityEnrollPlanRepository enrollPlanRepository = new UniversityEnrollPlanRepository())
            {
                //var enrollPlan = enrollPlanRepository.Get(enrollPlanId);
                //if (enrollPlan != null)
                //{
                //    enrollPlanRepository.Remove(enrollPlan);
                //    enrollPlanRepository.Commit();
                //}
            }
        }

        public void AddUniversity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university");

            using (UniversityRepository universityRepository = new UniversityRepository())
            {
                universityRepository.Add(university);
                universityRepository.Commit();
            }
        }

        public void UpdateUniversity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university");

            using (UniversityRepository universityRepository = new UniversityRepository())
            {
                var original = universityRepository.Get(university.Id);
                universityRepository.Merge(university);
                universityRepository.Commit();
            }
        }

        public void RemoveUniversity(Guid universityId)
        {
            using (UniversityRepository universityRepository = new UniversityRepository())
            {
                var university = universityRepository.Get(universityId);
                if (university != null)
                {
                    universityRepository.Remove(university);
                    universityRepository.Commit();
                }
            }
        }


        public IList<University> GetUniversities<KProperty>(int pageIndex, int pageCount, out int totalPagesCount, Expression<Func<University, KProperty>> orderByExpression, bool ascending, Expression<Func<University, bool>> filter = null)
        {
            using (UniversityRepository universityRepository = new UniversityRepository())
            {
                return universityRepository.GetPaged(pageIndex, pageCount, out totalPagesCount, orderByExpression, true, filter); 
            }
        }

        public IList<University> GetFiltered(System.Linq.Expressions.Expression<Func<University, bool>> filter)
        {
            using (UniversityRepository universityRepository = new UniversityRepository())
            {
                return universityRepository.GetFiltered(filter);
            }
        }


        public void AddSpeciality(Speciality speciality)
        {
            if (speciality == null)
                throw new ArgumentNullException("speciality");

            using (SpecialityRepository repository = new SpecialityRepository())
            {
                //var existedSpecialities = repository.GetFiltered(s => s.Name == speciality.Name && s.UniversityId == speciality.UniversityId);
                //if (existedSpecialities != null)
                //{
                //    // TODO: throw existing speciality of that university
                //}
                //repository.Add(speciality);
                //repository.Commit();
            }
        }

        public void UpdateSpeciality(Speciality speciality)
        {
            if (speciality == null)
                throw new ArgumentNullException("speciality");

            using (SpecialityRepository repository = new SpecialityRepository())
            {
                repository.Modify(speciality);
                repository.Commit();
            }
        }

        public void RemoveSpeciality(Guid specialityId)
        {
            using (SpecialityRepository repository = new SpecialityRepository())
            {
                var speciality = repository.Get(specialityId);
                if (speciality != null)
                {
                    repository.Remove(speciality);
                    repository.Commit();
                }
            }
        }

        public void AddUniversityAcceptanceStatistic(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            if (universityAcceptanceStatistic == null)
                throw new ArgumentNullException("universityAcceptanceStatistic");

            using (UniversityAcceptanceStatisticRepository repository = new UniversityAcceptanceStatisticRepository())
            {
                var existedUniversityAcceptanceStatistic = repository.GetFiltered(u => u.UniversityId == universityAcceptanceStatistic.UniversityId && u.Year == universityAcceptanceStatistic.Year);
                if (existedUniversityAcceptanceStatistic != null)
                {
                    // TODO: throw existing speciality of that UniversityAcceptanceStatistic
                }
                repository.Add(universityAcceptanceStatistic);
                repository.Commit();
            }
        }

        public void UpdateUniversityAcceptanceStatistic(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            if (universityAcceptanceStatistic == null)
                throw new ArgumentNullException("universityAcceptanceStatistic");

            using (UniversityAcceptanceStatisticRepository repository = new UniversityAcceptanceStatisticRepository())
            {
                repository.Modify(universityAcceptanceStatistic);
                repository.Commit();
            }
        }

        public void RemoveUniversityAcceptanceStatistic(Guid universityAcceptanceStatisticId)
        {
            using (UniversityAcceptanceStatisticRepository repository = new UniversityAcceptanceStatisticRepository())
            {
                //var universityAcceptanceStatistic = repository.Get(universityAcceptanceStatisticId);
                //if (universityAcceptanceStatistic != null)
                //{
                //    repository.Remove(universityAcceptanceStatistic);
                //    repository.Commit();
                //}
            }
        }

        //public IList<SpecialityDTO> GetSpecialitiesByUniversityId(Guid universityId)
        //{
        //    using (SpecialityRepository repository = new SpecialityRepository())
        //    {
        //        return repository.GetSpecialitiesByUniversityId(universityId);
        //    }
        //}


        public IList<University> GetAll()
        {
            using (UniversityRepository repository = new UniversityRepository())
            {
                return repository.GetAll();
            }
        }


        //public IList<SpecialityEnrollPlansDTO> GetSpecialityEnrollPlansByUniversityId(Guid universityId)
        //{
        //    using (SpecialityEnrollPlanRepository repository = new SpecialityEnrollPlanRepository())
        //    {
        //        return repository.GetSpecialityEnrollPlansByUniversityId(universityId);
        //    }
        //}

        //public IList<SpecialityEnrollPlansDTO> GetSpecialityEnrollPlansByUniversityIdAndProvince(Guid universityId, string province)
        //{
        //    using (SpecialityEnrollPlanRepository repository = new SpecialityEnrollPlanRepository())
        //    {
        //        return repository.GetSpecialityEnrollPlansByUniversityIdAndProvince(universityId, province);
        //    }
        //}


        
    }
}
