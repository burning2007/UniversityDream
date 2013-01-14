using System;
using System.Collections.Generic;
using GF.Domain.Seedwork;

namespace GF.Domain.Context
{
    public interface IUserRepository : IRepository<User>
    {
        User Get(Guid userId);
        User Get(string userName);

    }

    public interface IRoleRepository : IRepository<Role>
    {
        Role Get(string name);
    }

    public interface IAchievementRepository : IRepository<Achievement>
    {

    }

    public interface IRegionRepository : IRepository<Region>
    {
 
    }

    public interface IApplicationRepository : IRepository<Application>
    {
        Application Get(Guid applicationId);
        IList<ApplicationsDTO> GetByUserId(Guid userId);

    }
    public interface IApplicationStatisticRepository : IRepository<ApplicationStatistic>
    {
        //IList<ApplicationSequenceProvinceStatisticDTO> GetApplicationSequenceProvinceStatistic(Guid specialityId, string province, int applicationSequence);
    }
    //public interface IEnrollPlanRepository : IRepository<EnrollPlan>
    //{

    //}
    public interface IScorePublishRepository : IRepository<ScorePublish>
    {
        ScorePublish GetByProvince(Guid provinceId);
    }
    public interface ISpecialityRepository : IRepository<Speciality>
    {
        Speciality Get(Guid specialityId);
    }
    public interface ISpecialityAcceptanceStatisticRepository : IRepository<SpecialityAcceptanceStatistic>
    {

    }
    public interface IUniversityRepository : IRepository<University>
    {
        University Get(Guid universityId);
    }
    public interface IUniversityAcceptanceStatisticRepository : IRepository<UniversityAcceptanceStatistic>
    {

    }
}
