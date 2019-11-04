using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tilbud.DAL
{
    public interface IUsersRepository : IDisposable
    {
        IEnumerable<Users> GetUsers();
        Users GetUsersByID(int usersId);
        void InsertUsers(Users users);
        void DeleteUsers(int usersID);
        void UpdateUsers(Users users);
        void Save();
    }
}
