using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PublisherRepository : Repository<Publisher>
    {
        public PublisherRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Gets all publishers from database
        /// </summary>
        /// <returns>LINQ query containing all publishers</returns>
        public override IQueryable<Publisher> GetAll()
        {
            var query = from p in Entities
                        select p;
            return query;
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> of type <see cref="Publisher"/> into the database
        /// </summary>
        /// <param name="entity">Publisher intended for adding into the database</param>
        /// <returns>1 if adding the publisher was successful, 0 if not</returns>
        public override int Add(Publisher entity)
        {
            var publisher = new Publisher
            {
                Name = entity.Name,
                Founded = entity.Founded
            };

            Entities.Add(publisher);
            return SaveChanges();
        }
    }
}
