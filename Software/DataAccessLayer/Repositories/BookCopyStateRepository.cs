using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BookCopyStateRepository : Repository<BookCopyStateRepository>
    {
        public BookCopyStateRepository(RPP22_07_DBEntities context) : base(context)
        {
        }

        public override IQueryable<BookCopyStateRepository> GetAll()
        {
            var query = from b in Entities
                        select b;
            return query;
        }
    }
}
