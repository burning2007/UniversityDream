using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using GF.Domain.Context;
using GF.Infrastructure.Data.Seedwork;

namespace GF.Infrastructure.Data.Context
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private ApplicationContext appContext;
        public UserRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override void Add(User user)
        {
            appContext.AddToUsers(user);
        }

        public User Get(Guid userId)
        {
            var users = appContext.GetUserById(userId);
            var user = users.SingleOrDefault<User>();
            if (user != null)
                user.Achievements.Load();
            return user;
        }

        public User Get(string userName)
        {
            var users = appContext.GetUserByName(userName);
            var user = users.SingleOrDefault<User>();
            if (user != null)
                user.Achievements.Load();
            return user;
        }

        public override IList<User> GetFiltered(Expression<Func<User, bool>> filter)
        {
            return appContext.Users.Where(filter).ToList<User>();
        }

        public override IList<User> GetAll()
        {
            return appContext.Users.ToList<User>();
        }

        public override void Modify(User user)
        {
            if (user != (User)null)
            {
                appContext.AttachTo("Users", user);
                appContext.ObjectStateManager.ChangeObjectState(user, System.Data.EntityState.Modified);
            }
        } 

        public bool CheckAccountExistById(Guid id)
        {
            var isexist = false;
            appContext.CheckUserExistById(id, new ObjectParameter("isExist", isexist));
            return isexist;
        }

        public bool CheckAccountExistByName(string userName)
        {
            var isexist = false;
            appContext.CheckUserExistByName(userName, new ObjectParameter("isExist", isexist));
            return isexist;
        }

        public override void TrackEntity(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            context.AttachTo("Users", user);
            context.ObjectStateManager.ChangeObjectState(user, System.Data.EntityState.Unchanged);
        }

        public override void Merge(User user)
        {
            context.ApplyCurrentValues<User>("Users", user);
        }

        public override void Refresh(object user, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            appContext.Refresh(refreshMode, user);
        }



       
    }
}
