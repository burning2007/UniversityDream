using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;
using GF.Infrastructure.Data.Context;

namespace GF.Application.Context.UniversityServices
{
    public class UniversityService : IUniversityService
    {

        public void PublishEnrollPlan(EnrollPlan enrollPlan)
        {
            if (enrollPlan == null)
                throw new ArgumentNullException("enrollPlan");

            EnrollPlanRepository enrollPlanRepository = new EnrollPlanRepository();
            var ens = enrollPlanRepository.GetFiltered(e => e.Year.Year == enrollPlan.Year.Year && e.Province == enrollPlan.Province && e.SpecialityId == enrollPlan.SpecialityId);
            if (ens != null)
            {
                // TODO: throw existing exception
            }
            enrollPlanRepository.Add(enrollPlan);
            enrollPlanRepository.Commit();
        }

        public void UpdateEnrollPlan(EnrollPlan enrollPlan)
        {
            if (enrollPlan == null)
                throw new ArgumentNullException("enrollPlan");

            EnrollPlanRepository enrollPlanRepository = new EnrollPlanRepository();
            var enroll = enrollPlanRepository.Get(enrollPlan.Id);
            if (enroll == null)
            {
                // TODO: throw not existing exception
            }
            enrollPlanRepository.Modify(enrollPlan);
            enrollPlanRepository.Commit();
        }

        public void RemoveEnrollPlan(Guid enrollPlanId)
        {
            EnrollPlanRepository enrollPlanRepository = new EnrollPlanRepository();
            var enrollPlan = enrollPlanRepository.Get(enrollPlanId);
            if (enrollPlan != null)
            {
                enrollPlanRepository.Remove(enrollPlan);
                enrollPlanRepository.Commit();
            }
        }

        public void AddUniversity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university");

            UniversityRepository universityRepository = new UniversityRepository();
            universityRepository.Add(university);
            universityRepository.Commit();
        }

        public void UpdateUniversity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university");

            UniversityRepository universityRepository = new UniversityRepository();
            universityRepository.Modify(university);
            universityRepository.Commit();
        }

        public void RemoveUniversity(Guid universityId)
        {
            UniversityRepository universityRepository = new UniversityRepository();
            var university = universityRepository.Get(universityId);
            if (university != null)
            {
                universityRepository.Remove(university);
                universityRepository.Commit();
            }
        }


        public void AddSpeciality(Speciality speciality)
        {
            if (speciality == null)
                throw new ArgumentNullException("speciality");

            UniversityRepository universityRepository = new UniversityRepository();
            var university = universityRepository.Get(speciality.UniversityId);
            if (university != null)
            {
                if (university.Specialities.Any<Speciality>(s => s.Name == speciality.Name && s.UniversityId == speciality.UniversityId))
                {
                    // TODO: throw existing speciality of that university
                    throw new Exception();
                }
                universityRepository.TrackEntity(university);
                university.Specialities.Add(speciality);
                universityRepository.Commit();
            }
        }

        public void UpdateSpeciality(Speciality speciality)
        {
            if (speciality == null)
                throw new ArgumentNullException("speciality");

            UniversityRepository universityRepository = new UniversityRepository();
            var university = universityRepository.Get(speciality.UniversityId);
            if (university != null)
            {
                var existedSpeciality = university.Specialities.SingleOrDefault<Speciality>(s => s.Id == speciality.Id);
                if (existedSpeciality != null)
                {
                    universityRepository.TrackEntity(university);
                    existedSpeciality = speciality;
                    universityRepository.Commit();
                }
            }
        }

        public void RemoveSpeciality(Speciality speciality)
        {
            if (speciality == null)
                throw new ArgumentNullException("speciality");

            UniversityRepository universityRepository = new UniversityRepository();
            var university = universityRepository.Get(speciality.UniversityId);
            if (university != null)
            {
                //universityRepository.TrackEntity(university);
                university.Specialities.Remove(speciality);
                universityRepository.Modify(university);
                universityRepository.Commit();
            }
        }
    }
}
