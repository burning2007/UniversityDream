using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;

namespace GF.Application.Context.Services
{
    public interface IUniversityService
    {
        void PublishEnrollPlan(UniversityEnrollPlan enrollPlan);
        void UpdateEnrollPlan(UniversityEnrollPlan enrollPlan);
        void RemoveEnrollPlan(Guid enrollPlanId);

        void AddUniversity(University university);
        void UpdateUniversity(University university);
        void RemoveUniversity(Guid universityId);
        IList<University> GetAll();

        void AddSpeciality(Speciality speciality);
        void UpdateSpeciality(Speciality speciality);
        void RemoveSpeciality(Guid specialityId);
        IList<SpecialityDTO> GetSpecialitiesByUniversityId(Guid universityId);

        void AddUniversityAcceptanceStatistic(UniversityAcceptanceStatistic universityAcceptanceStatistic);
        void UpdateUniversityAcceptanceStatistic(UniversityAcceptanceStatistic universityAcceptanceStatistic);
        void RemoveUniversityAcceptanceStatistic(Guid universityAcceptanceStatisticId);
    }
}
