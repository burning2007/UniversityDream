using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;

namespace GF.Application.Context.Services
{
    public interface IUserAppService
    {
        void Register(User user);

        bool Login(string userName, string password);

        void ChangePassword(string userName, string oldPassword, string newPassword);

        void ResetPassword(string userName, string email);

        void LockAccount(string userName);

        void UnlockAccount(string userName);

        void Recharge(string userName, int coins);

        void ChangeIDCard(string userName, string idCardNo, string chineseName);

        bool ValidateIDCard(string userName, string idCardNo, string chineseName);

        void ChangeAchievement(Achievement achievement);

        void ChangeUser(string userName, string qq, bool gender);

        User GetUser(string userName);

        Role GetRole(string roleName);
    }
}
