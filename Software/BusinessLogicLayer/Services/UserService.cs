using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class UserService
    {
        public bool AddUser(User user)
        {
            using (var repo = new UserRepository())
            {
                var num = repo.Add(user);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateUser(User user)
        {
            using (var repo = new UserRepository())
            {
                var num = repo.Update(user);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeleteUser(User user)
        {
            using (var repo = new UserRepository())
            {
                var num = repo.Delete(user);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<User> GetUsers()
        {
            using(var repo = new UserRepository())
            {
                var users = repo.GetAll();
                return users.ToList();
            }
        }

        public List<User> GetUserByUsername(string username)
        {
            using (var repo = new UserRepository())
            {
                var user = repo.GetByUsername(username);
                return user.ToList();
            }
        }
    }
}
