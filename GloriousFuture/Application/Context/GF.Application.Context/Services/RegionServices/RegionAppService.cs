using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;
using System.Linq.Expressions;
using GF.Infrastructure.Data.Context;

namespace GF.Application.Context.Services
{
    public class RegionAppService : IRegionAppService
    {

        public IList<Region> GetFiltered(Expression<Func<Region, bool>> filter)
        {
            using (IRegionRepository regionRepository = new RegionRepository())
            {
                return regionRepository.GetFiltered(filter);
            }
        }
    }
}
