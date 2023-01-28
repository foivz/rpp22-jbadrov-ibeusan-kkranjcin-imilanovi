using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository() : base(new RPP22_07_DBEntities())
        {
        }

        public override IQueryable<Book> GetAll()
        {
            var query = from b in Entities.Include("BorrowableBookState")
                                          .Include("BookAuthors")
                                          .Include("BookAuthors.Author")
                                          .Include("BookCopies")
                                          .Include("BookGenres")
                                          .Include("BookGenres.Genre")
                        select b;
            return query;
        }

        public override int Add(Book entity)
        {
            var book = new Book
            {
                Title = entity.Title,
                NumberOfPages = entity.NumberOfPages,
                IdBorrowableState = entity.IdBorrowableState,
                ISBN = entity.ISBN
            };

            Entities.Add(book);
            return SaveChanges();
        }

        public override int Update(Book entity)
        {
            var book = Entities.SingleOrDefault(b => b.Id == entity.Id);
            book.Title = entity.Title;
            book.NumberOfPages = entity.NumberOfPages;
            book.IdBorrowableState = entity.IdBorrowableState;
            book.ISBN = entity.ISBN;

            return SaveChanges();
        }

        public IQueryable<Book> GetById(int id)
        {
            var query = from b in Entities.Include("BorrowableBookState")
                                          .Include("BookAuthors")
                                          .Include("BookAuthors.Author")
                                          .Include("BookCopies")
                                          .Include("BookGenres")
                                          .Include("BookGenres.Genre")
                        where b.Id == id
                        select b;
            return query;
        }
    }
}
