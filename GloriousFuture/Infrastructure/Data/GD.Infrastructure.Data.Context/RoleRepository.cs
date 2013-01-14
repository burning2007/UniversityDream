using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;
using GF.Infrastructure.Data.Seedwork;

namespace GF.Infrastructure.Data.Context
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private ApplicationContext appContext;
        public RoleRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }
        public Role Get(string name)
        {
            return appContext.Roles.SingleOrDefault<Role>(r => r.Name == name);
        }
    }
}
