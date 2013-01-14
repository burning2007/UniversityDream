using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Domain.Context.Services.AccountService
{
    public interface IUserService
    {
        void Register(User user);

        void ChangeAchievement(User user, Achievement achievement);
    }
}
