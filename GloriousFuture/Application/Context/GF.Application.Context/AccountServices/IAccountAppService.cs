using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;

namespace GF.Application.Context
{
    public interface IAccountAppService
    {
        void Register(Account account);

        bool Login(string userName, string password);

        void ActivateAccount(Guid accountId, string activationCode);

        void SendActivationMail(string email);

        void ChangePassword(Guid accountId, string oldPassword, string newPassword);

        void ResetPassword(Guid accountId, string email);

        void LockAccount(Guid accountId);

        void UnlockAccount(Guid accountId);

        void ChangeAchievement(AccountDTO achievement);

        void UpdateAccount(AccountDTO account_dto);

        void Recharge(Guid accountId, int coins);

        void CreateApplication(GF.Domain.Context.Application application);

        void UpdateApplication(List<GF.Domain.Context.Application> applicationList);

        void RemoveApplication(List<GF.Domain.Context.Application> applicationList);

    }
}
