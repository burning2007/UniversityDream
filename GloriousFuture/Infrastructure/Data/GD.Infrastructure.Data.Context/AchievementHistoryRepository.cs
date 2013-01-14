using GF.Infrastructure.Data.Seedwork;
using GF.Domain.Context;

namespace GF.Infrastructure.Data.Context
{
    public class AchievementHistoryRepository : Repository<AchievementHistory>
    {
        public AchievementHistoryRepository():base()
        {
            context = new ApplicationContext();
        }

    }
}
