using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository() : base(new RPP22_07_DBEntities())
        {
        }

        public override IQueryable<User> GetAll()
        {
            var query = from u in Entities
                        select u;
            return query;
        }

        public IQueryable<User> GetByUsername(string username)
        {
            var query = from u in Entities
                        where u.Username == username
                        select u;
            return query;
        }

        public override int Add(User entity)
        {
            var user = new User
            {
                FirstName= entity.FirstName,
                LastName= entity.LastName,
                Username = entity.Username,
                Password= entity.Password
            };

            Entities.Add(user);
            return SaveChanges();
        }

        public override int Update(User entity)
        {
            var user = Entities.SingleOrDefault(u => u.Id == entity.Id);
            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.Username = entity.Username;
            user.Password = entity.Password;

            return SaveChanges();
        }
    }
}
