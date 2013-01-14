using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;

namespace GF.Application.Context
{
    public interface IAccountService
    {
        void Register(AccountDTO account_dto);

        void ChangePassword(AccountDTO account_dto, string password);

        void ResetPassword(AccountDTO account_dto);

        void LockAccount(Guid accountId);

        void LockAccount(AccountDTO account_dto);

        void UnlockAccount(Guid accountId);

        void UnlockAccount(AccountDTO account_dto);

        void ChangeAchievement(AccountDTO achievement);

        void UpdateAccount(AccountDTO account_dto);


    }
}
