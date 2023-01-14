using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BorrowedBookStateRepository : Repository<BorrowedBookState>
    {
        public BorrowedBookStateRepository() : base(new RPP22_07_DBEntities())
        {
        }

        public override IQueryable<BorrowedBookState> GetAll()
        {
            var query = from b in Entities
                        select b;
            return query;
        }
    }
}
