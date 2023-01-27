using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DataGridViewModels;

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

        public IQueryable<BorrowedBookDetails> GetBorrowedBookDetailsByLibraryMember(int libraryMemberId)
        {
            var query = from bbo in Context.BorrowedBookOverviews
                        join bc in Context.BookCopies on bbo.IdBookCopy equals bc.Id
                        join b in Context.Books on bc.IdBook equals b.Id
                        where bbo.IdLibraryMember == libraryMemberId && bbo.IdState == 1
                        select new BorrowedBookDetails
                        {
                            Id = bbo.Id,
                            BorrowedDate = bbo.BorrowDate,
                            ReturnDate = bbo.ReturnDate,
                            Title = b.Title
                        };

            return query;
        }

        public IQueryable<BorrowedBookOverview> GetBorrowedBookOverviewsByLibrraryMember(int LibraryMemberId)
        {
            var query = from b in Entities
                        where b.IdLibraryMember == LibraryMemberId && b.IdState == 1
                        select b;
            return query;
        }

        public IQueryable<BorrowedBookOverview> GetBookOverviewByBookIDAndLibraryMemberId(int bookId, int libraryMemberId)
        {
            var query = from b in Entities
                        where b.IdBookCopy == bookId && b.IdLibraryMember == libraryMemberId
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

        public override int Update(BorrowedBookOverview entity)
        {
            var borrowedBookOverview = Entities.SingleOrDefault(b => b.Id == entity.Id);
            //borrowedBookOverview.IdLibraryMember = entity.IdLibraryMember;
            borrowedBookOverview.IdState = entity.IdState;
            borrowedBookOverview.BorrowDate = entity.BorrowDate;
            borrowedBookOverview.ReturnDate = entity.ReturnDate;
           
            
            //borrowedBookOverview.IdBookCopy = entity.IdState;


            return SaveChanges();
        }

        

        public bool IsReserved(int id)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetBookCopyById(id).ToList();
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

        public bool IsBorrowed(int id)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetBookCopyById(id).ToList();
                foreach (var book in bookCopy)
                {
                    if (book != null)
                    {
                        if (book.BorrowedBookOverviews != null)
                        {
                            foreach (var overview in book.BorrowedBookOverviews)
                            {
                                if (overview.IdState == 1)
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

        public bool IsReservedForLibraryMember(int bookId, int libraryMemberId)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetBookCopyById(bookId).ToList();
                foreach (var book in bookCopy)
                {
                    if (book != null)
                    {
                        if (book.BorrowedBookOverviews != null)
                        {
                            foreach (var overview in book.BorrowedBookOverviews)
                            {
                                if (overview.IdState == 3 && overview.IdLibraryMember == libraryMemberId) 
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
