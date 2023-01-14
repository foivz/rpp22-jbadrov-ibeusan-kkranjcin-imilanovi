using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BookCopyStateRepository : Repository<BorrowableBookState>
    {
        public BookCopyStateRepository() : base(new RPP22_07_DBEntities())
        {
        }

        public override IQueryable<BorrowableBookState> GetAll()
        {
            var query = from b in Entities
                        select b;
            return query;
        }
    }
}
