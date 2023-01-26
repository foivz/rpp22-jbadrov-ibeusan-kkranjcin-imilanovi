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
                IdBookCopy = entity.IdBookCopy,
                IdLibraryMember = entity.IdLibraryMember,
                IdState = entity.IdState,
                //BookCopy = entity.BookCopy,
                //BorrowedBookState = entity.BorrowedBookState,
               //LibraryMember = entity.LibraryMember,
                BorrowDate = entity.BorrowDate,
                ReturnDate = entity.ReturnDate
            };

            Entities.Add(borrowedBookOverview);
            return SaveChanges();
        }

        public bool IsReserved(int id)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetBookById(id).ToList();
                foreach (var book in bookCopy)
                {
                    if (book != null)
                    {
                        if (book.BorrowedBookOverviews != null)
                        {
                            foreach (var overview in book.BorrowedBookOverviews)
                            {
                                if (overview.IdState == 3)
                                {
                                    return true;
                                }
                            }
                        }

                    }

                }
                
                
            }
            return false;
        }
    }

   
}
