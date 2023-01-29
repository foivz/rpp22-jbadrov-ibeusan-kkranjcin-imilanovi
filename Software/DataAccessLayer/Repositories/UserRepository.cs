using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Gets all users from database
        /// </summary>
        /// <returns>LINQ query containing all users</returns>
        public override IQueryable<User> GetAll()
        {
            var query = from u in Entities
                        select u;
            return query;
        }

        /// <summary>
        /// Gets a user with the matching <paramref name="username"/>
        /// </summary>
        /// <param name="username">Username of a user</param>
        /// <returns>LINQ query containing the users</returns>
        public IQueryable<User> GetByUsername(string username)
        {
            var query = from u in Entities
                        where u.Username == username
                        select u;
            return query;
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> of type <see cref="User"/> into the database
        /// </summary>
        /// <param name="entity">User intended for adding into the database</param>
        /// <returns>1 if adding the user was successful, 0 if not</returns>
        public override int Add(User entity)
        {
            var user = new User
            {
                FirstName= entity.FirstName,
                LastName= entity.LastName,
                Username = entity.Username,
                Password= entity.Password,
                IdRole = entity.IdRole
            };

            Entities.Add(user);
            return SaveChanges();
        }

        /// <summary>
        /// Updates the <paramref name="entity"/> of type <see cref="User"/> into the database
        /// </summary>
        /// <param name="entity">User intended for updating into the database</param>
        /// <returns>1 if update is successful, 0 if not</returns>
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
