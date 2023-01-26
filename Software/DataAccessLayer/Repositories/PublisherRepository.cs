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

        public override IQueryable<Publisher> GetAll()
        {
            var query = from p in Entities
                        select p;
            return query;
        }

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

        public override int Update(Publisher entity)
        {
            var publisher = Entities.SingleOrDefault(p => p.Id == entity.Id);
            publisher.Name = entity.Name;

            return SaveChanges();
        }
    }
}
