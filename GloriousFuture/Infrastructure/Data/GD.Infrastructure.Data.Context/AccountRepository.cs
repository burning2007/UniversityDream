using GF.Domain.Context;
using GF.Infrastructure.Data.Seedwork;
using System.Linq;
using System.Data.Objects;
using System;
using System.Collections.Generic;

namespace GF.Infrastructure.Data.Context
{
    public class AccountRepository : Repository<Account>
    {
        private ApplicationContext appContext;
        public AccountRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override void Add(Account account)
        {
            appContext.AddToAccounts(account);
        }

        public override Account Get(System.Guid id)
        {
            return appContext.GetAccountById(id).First<Account>();
        }

        public Account Get(string accountName)
        {
            return appContext.GetAccountByName(accountName).First<Account>();
        }


        public bool CheckAccountExistById(Guid id)
        {
            var isexist = false;
            appContext.CheckAccountExistById(id, new ObjectParameter("isExist", isexist));
            return isexist;
        }

        public bool CheckAccountExistByName(string accountName)
        {
            var isexist = false;
            appContext.CheckAccountExistByName(accountName, new ObjectParameter("isExist", isexist));
            return isexist;
        }

        public AccountDTO GetAccountDTO(string accountName)
        {
            return appContext.GetAccountDTOByName(accountName).First<AccountDTO>();
        }

        public override void TrackEntity(Account account)
        {
            if (account == null)
                throw new ArgumentNullException("account");

            context.AttachTo("Accounts", account);
            context.ObjectStateManager.ChangeObjectState(account, System.Data.EntityState.Unchanged);
        }

        public override void Merge(Account account)
        {
            context.ApplyCurrentValues<Account>("Accounts", account);
        }

    }
}
