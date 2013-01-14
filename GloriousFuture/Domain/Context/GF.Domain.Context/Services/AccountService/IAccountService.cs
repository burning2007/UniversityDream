using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GF.Domain.Context.Services.AccountService
{
    public interface IAccountService
    {
        void Register(Account account);

        void ChangeAchievement(Account account, Achievement achievement);
    }
}
