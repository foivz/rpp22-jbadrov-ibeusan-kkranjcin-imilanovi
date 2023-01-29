using System.Linq;
using DataAccessLayer.DataGridViewModel;

namespace DataAccessLayer.Repositories
{
    public class BorrowedBookOverviewRepository : Repository<BorrowedBookOverview>
    {
        public BorrowedBookOverviewRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Gets all borrowed book overviews from database
        /// </summary>
        /// <returns>LINQ query containing all borrowed book overviews</returns>
        public override IQueryable<BorrowedBookOverview> GetAll()
        {
            var query = from b in Entities.Include("BookCopy")
                        select b;
            return query;
        }

        /// <summary>
        /// Gets details about borrowed book which include borrow and return date and title of a book
        /// </summary>
        /// <param name="libraryMemberId">Id of a library member</param>
        /// <returns>LINQ query containing details of borrowed book</returns>
        public IQueryable<BorrowedBookDetails> GetDetailsByLibraryMember(int libraryMemberId)
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

        /// <summary>
        /// Gets book overview for given id of a book and id of a library member
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="libraryMemberId"></param>
        /// <returns>LINQ query containing borrowed book overviews that match given id of a book and given id of a library member</returns>
        public IQueryable<BorrowedBookOverview> GetByBookIdAndLibraryMemberId(int bookId, int libraryMemberId)
        {
            var query = from b in Entities
                        where b.IdBookCopy == bookId && b.IdLibraryMember == libraryMemberId
                        select b;
            return query;
        }

        /// <summary>
        /// Gets book overview by given <paramref name="id"/>
        /// </summary>
        /// <param name="id">Id of a book overview</param>
        /// <returns>LINQ query containing borrowed book overview with matching id</returns>
        public IQueryable<BorrowedBookOverview> GetById(int id)
        {
            var query = from b in Entities
                        where b.Id ==id
                        select b;
            return query;
        }

        /// <summary>
        /// Gets book overviews by given id of a book and checks if it is reserved
        /// </summary>
        /// <param name="idBook">Id of a book that is being checked for reservation</param>
        /// <returns>LINQ query containing borrowed book overview that matches given id of a book and state of being reserved</returns>
        public IQueryable<BorrowedBookOverview> GetReservedByIdBook(int idBook)
        {
            var query = from b in Entities
                        where b.IdBookCopy == idBook && b.IdState == 3
                        select b;
            return query;
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> of type <see cref="BorrowedBookOverview"/> into the database
        /// </summary>
        /// <param name="entity"><see cref="BorrowedBookOverview"/> intended for adding into the database</param>
        /// <returns>1 if adding borrowed book overview was successful, 0 if not</returns>
        public override int Add(BorrowedBookOverview entity)
        {
            var borrowedBookOverview = new BorrowedBookOverview
            { 
                IdBookCopy = entity.IdBookCopy,
                IdLibraryMember = entity.IdLibraryMember,
                IdState = entity.IdState,
                BorrowDate = entity.BorrowDate,
                ReturnDate = entity.ReturnDate
            };

            Entities.Add(borrowedBookOverview);
            return SaveChanges();
        }

        /// <summary>
        /// Updates the <paramref name="entity"/> of type <see cref="BorrowedBookOverview"/> into the database
        /// </summary>
        /// <param name="entity"><see cref="BorrowedBookOverview"/> intended for updating into the database</param>
        /// <returns>1 if update is successful, 0 if not</returns>
        public override int Update(BorrowedBookOverview entity)
        {
            var borrowedBookOverview = Entities.SingleOrDefault(b => b.Id == entity.Id);
            borrowedBookOverview.IdState = entity.IdState;
            borrowedBookOverview.BorrowDate = entity.BorrowDate;
            borrowedBookOverview.ReturnDate = entity.ReturnDate;
            return SaveChanges();
        }

        /// <summary>
        /// Checks if state of borrowed book overview is reserved
        /// </summary>
        /// <param name="id">Id of a book that is being checked for reservation</param>
        /// <returns><see langword="True"/> if book is reserved, <see langword="False"/> if it is not</returns>
        public bool IsReserved(int id)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetById(id).ToList();
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

        /// <summary>
        /// Checks if state of borrowed book overview is borrowed
        /// </summary>
        /// <param name="id">Id of a book that is being checked</param>
        /// <returns><see langword="True"/> if book is borrowed, <see langword="False"/> if it is not</returns>
        public bool IsBorrowed(int id)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetById(id).ToList();
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

        /// <summary>
        /// Gets book by given id and checks if library member reserved it
        /// </summary>
        /// <param name="bookId">Id of a book that is being checked for reservation</param>
        /// <param name="libraryMemberId">Id of a library member that is being checked for reservation</param>
        /// <returns><see langword="True"/> if book is reserved by the library member, <see langword="False"/> if it is not</returns>
        public bool IsReservedForLibraryMember(int bookId, int libraryMemberId)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetById(bookId).ToList();
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
