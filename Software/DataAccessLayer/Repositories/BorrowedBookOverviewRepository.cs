using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BorrowedBookOverviewRepository : Repository<BorrowedBookOverview>
    {
        public BorrowedBookOverviewRepository() : base(new RPP22_07_DBEntities())
        {
        }

        public override IQueryable<BorrowedBookOverview> GetAll()
        {
            var query = from b in Entities
                        select b;
            return query;
        }

        public override int Add(BorrowedBookOverview entity)
        {
            var borrowedBookOverview = new BorrowedBookOverview 
            { 
                BookCopy = entity.BookCopy,
                BorrowedBookState = entity.BorrowedBookState,
                LibraryMember = entity.LibraryMember,
                BorrowDate = entity.BorrowDate,
                ReturnDate = entity.ReturnDate
            };

            Entities.Add(borrowedBookOverview);
            return SaveChanges();
        }
    }
}
