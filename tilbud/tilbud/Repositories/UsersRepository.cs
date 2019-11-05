using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tilbud.DAL;

namespace tilbud.Repositories
{
    public class UsersRepository : IUsersRepository, IDisposable
    {
        private prj4databaseContext context;

        public UsersRepository(prj4databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Users> GetUsers()
        {
            return context.Users.ToList();
        }

        public Users GetUsersByID(int id)
        {
            return context.Users.Find(id);
        }

        public void InsertUsers(Users users)
        {
            context.Users.Add(users);
        }

        public void DeleteUsers(int usersID)
        {
            Users users = context.Users.Find(usersID);
            context.Users.Remove(users);
        }

        public void UpdateUsers(Users users)
        {
            context.Entry(users).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
