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

        public IQueryable<Book> GetBookById(int id)
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

        public IQueryable<Book> GetBooksByTitle(string title)
        {
            var query = from b in Entities
                        where b.Title == title
                        select b;
            return query;
        }

        public IQueryable<Book> GetBooksByAuthors(string author)
        {
            var query = from b in Entities
                        where b.BookAuthors.All(a => a.Author.FirstName == author || a.Author.LastName == author || a.Author.FirstName + ' ' + a.Author.LastName == author)
                        select b;
            return query;
        }

        public IQueryable<Book> GetBooksByGenre(string genre)
        {
            var query = from b in Entities
                        where b.BookGenres.All(g => g.Genre.Name == genre)
                        select b;
            return query;
        }
    }
}
