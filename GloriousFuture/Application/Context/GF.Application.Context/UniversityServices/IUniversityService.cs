using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;

namespace GF.Application.Context.UniversityServices
{
    public interface IUniversityService
    {
        void PublishEnrollPlan(EnrollPlan enrollPlan);
        void UpdateEnrollPlan(EnrollPlan enrollPlan);
        void RemoveEnrollPlan(Guid enrollPlanId);

        void AddUniversity(University university);
        void UpdateUniversity(University university);
        void RemoveUniversity(Guid universityId);

        void AddSpeciality(Speciality speciality);
        void UpdateSpeciality(Speciality speciality);
        void RemoveSpeciality(Speciality speciality);

    }
}
