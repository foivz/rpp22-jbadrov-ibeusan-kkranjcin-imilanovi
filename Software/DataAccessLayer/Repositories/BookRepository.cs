using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Gets all books from database
        /// </summary>
        /// <returns>LINQ query containing all books</returns>
        public override IQueryable<Book> GetAll()
        {
            var query = from b in Entities.Include("BorrowableBookState")
                                          .Include("BookAuthors")
                                          .Include("BookCopies")
                                          .Include("BookGenres")
                        select b;
            return query;
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> of type <see cref="Book"/> into the database
        /// </summary>
        /// <param name="entity">Book intended for adding into the database</param>
        /// <returns>1 if adding the book was successful, 0 if not</returns>
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

        /// <summary>
        /// Updates the <paramref name="entity"/> of type <see cref="Book"/> into the database
        /// </summary>
        /// <param name="entity">Book intended for updating into the database</param>
        /// <returns>1 if update is successful, 0 if not</returns>
        public override int Update(Book entity)
        {
            var book = Entities.SingleOrDefault(b => b.Id == entity.Id);
            book.Title = entity.Title;
            book.NumberOfPages = entity.NumberOfPages;
            book.IdBorrowableState = entity.IdBorrowableState;
            book.ISBN = entity.ISBN;

            return SaveChanges();
        }

        /// <summary>
        /// Gets a book with the matching <paramref name="id"/>
        /// </summary>
        /// <param name="id">Id of the book</param>
        /// <returns>LINQ query containing the book</returns>
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
