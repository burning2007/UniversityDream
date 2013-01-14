using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;
using System.Linq.Expressions;

namespace GF.Application.Context.Services
{
    public interface IRegionAppService
    {
        IList<Region> GetFiltered(Expression<Func<Region, bool>> filter);
    }
}
