using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Infrastructure.Data.Seedwork;
using GF.Domain.Context;

namespace GF.Infrastructure.Data.Context
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {

         private ApplicationContext appContext;
         public RegionRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override IList<Region> GetFiltered(System.Linq.Expressions.Expression<Func<Region, bool>> filter)
        {
            return appContext.Regions.Where(filter).ToList<Region>();
        }
    }
}
