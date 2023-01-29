using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class UserService
    {
        /// <summary>
        /// Adds the <paramref name="user"/> into the database
        /// </summary>
        /// <param name="user">User intended for adding into the database</param>
        /// <returns><see langword="True"/> if author was added successfully, <see langword="False"/> if problem occurred</returns>
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

        /// <summary>
        /// Updates the <paramref name="user"/> in the database
        /// </summary>
        /// <param name="user">User intended for updating in the database</param>
        /// <returns><see langword="True"/> if update is successful, <see langword="False"/> if not</returns>
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

        /// <summary>
        /// Deletes the <paramref name="user"/> from the database
        /// </summary>
        /// <param name="user">User intended for deleting from the database</param>
        /// <returns><see langword="True"/> if delete is successful, <see langword="False"/> if not</returns>
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

        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns>List of <see cref="User"/> objects</returns>
        public List<User> GetUsers()
        {
            using(var repo = new UserRepository())
            {
                var users = repo.GetAll();
                return users.ToList();
            }
        }

        /// <summary>
        /// Gets a user which has a username that matches <paramref name="username"/>
        /// </summary>
        /// <returns>List of <see cref="User"/> objects</returns>
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
