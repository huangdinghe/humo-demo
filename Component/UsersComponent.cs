using Domain;
using Manager;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    public class UsersComponent : BaseComponent<Users, UsersManager>, IUsersService
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public Users Login(string usersname, string password)
        {
            Users users = manager.Login(usersname, password);
            return users;
        }
    }
}
