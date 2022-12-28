using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BorrowedBookStateRepository : Repository<BorrowedBookState>
    {
        public BorrowedBookStateRepository(RPP22_07_DBEntities context) : base(context)
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
