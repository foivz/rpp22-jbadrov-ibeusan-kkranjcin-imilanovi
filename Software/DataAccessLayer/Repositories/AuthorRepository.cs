using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AuthorRepository : Repository<Author>
    {
        public AuthorRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Gets all authors from database
        /// </summary>
        /// <returns>LINQ query containing all authors</returns>
        public override IQueryable<Author> GetAll()
        {
            var query = from a in Entities
                        select a;
            return query;
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> of type <see cref="Author"/> into the database
        /// </summary>
        /// <param name="entity">Author intended for adding into the database</param>
        /// <returns>1 if adding author was successful, 0 if not</returns>
        public override int Add(Author entity)
        {
            var author = new Author
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DateOfBirth = entity.DateOfBirth
            };

            Entities.Add(author);
            return SaveChanges();
        }

        /// <summary>
        /// Updates the <paramref name="entity"/> of type <see cref="Author"/> into the database
        /// </summary>
        /// <param name="entity">Author intended for updating into the database</param>
        /// <returns>1 if update is successful, 0 if not</returns>
        public override int Update(Author entity)
        {
            var author = Entities.SingleOrDefault(a => a.Id == entity.Id);
            author.FirstName = entity.FirstName;
            author.LastName = entity.LastName;
            author.DateOfBirth = entity.DateOfBirth;

            return SaveChanges();
        }
    }
}
