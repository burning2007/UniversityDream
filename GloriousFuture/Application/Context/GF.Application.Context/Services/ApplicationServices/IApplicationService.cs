using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;

namespace GF.Application.Context.Services
{
    public interface IApplicationService
    {
        void CreateApplication(GF.Domain.Context.Application application);

        void UpdateApplication(List<GF.Domain.Context.Application> applicationList);

        void RemoveApplication(List<GF.Domain.Context.Application> applicationList);

        IList<ApplicationsDTO> GetApplicationByUserId(Guid userId);

        //IList<ApplicationProvinceStatisticDTO> GetApplicationProvinceStatistic(Guid specialityId, string province);

        //IList<ApplicationUserStatisticDTO> GetApplicationUserStatistic(Guid specialityId, string province);

        //IList<ApplicationsDTO> GetLatestApplications();

        //IList<ApplicationScoreRankStatisticDTO> GetApplicationScoreRankStatistic(Guid specialityId, string province);

        //IList<ApplicationSequenceProvinceStatisticDTO> GetApplicationSequenceProvinceStatistic(Guid specialityId, string province, int applicationSequence);

        //IList<ApplicationSequenceScoreRankStatisticDTO> GetApplicationSequenceScoreRankStatistic(Guid specialityId, string province, int applicationSequence);

        //IList<TopPopularSpecialitiesDTO> GetTopPopularSpecialities();

    }
}
