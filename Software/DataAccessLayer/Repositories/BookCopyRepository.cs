using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BookCopyRepository : Repository<BookCopy>
    {
        public BookCopyRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Gets all copies of a book from database
        /// </summary>
        /// <returns>LINQ query containing all book copies</returns>
        public override IQueryable<BookCopy> GetAll()
        {
            var query = from b in Entities.Include("Publisher").Include("Book")
                        select b;
            return query;
        }

        /// <summary>
        /// Gets a book copy with the matching <paramref name="id"/>
        /// </summary>
        /// <param name="id">Id of the targeted book copy</param>
        /// <returns>LINQ query containing the copies of a book</returns>
        public IQueryable<BookCopy> GetById(int id)
        {
            var query = from b in Entities
                        where b.Id == id
                        select b;
            return query;
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> of type <see cref="BookCopy"/> into the database
        /// </summary>
        /// <param name="entity"><see cref="BookCopy"/> intended for adding into the database</param>
        /// <returns>1 if adding book copy was successful, 0 if not</returns>
        public override int Add(BookCopy entity)
        {
            var bookCopy = new BookCopy
            {
                Edition = entity.Edition,
                IdPublisher = entity.IdPublisher,
                IdBook = entity.IdBook,
                YearOfPublication = entity.YearOfPublication,
                Language = entity.Language
            };

            Entities.Add(bookCopy);
            return SaveChanges();
        }

        /// <summary>
        /// Updates the <paramref name="entity"/> of type <see cref="BookCopy"/> into the database
        /// </summary>
        /// <param name="entity"><see cref="BookCopy"/> intended for updating into the database</param>
        /// <returns>1 if update is successful, 0 if not</returns>
        public override int Update(BookCopy entity)
        {
            var bookCopy = Entities.SingleOrDefault(b => b.Id == entity.Id);
            bookCopy.Edition = entity.Edition;
            bookCopy.IdPublisher = entity.IdPublisher;
            bookCopy.IdBook = entity.IdBook;
            bookCopy.YearOfPublication = entity.YearOfPublication;
            bookCopy.Language = entity.Language;

            return SaveChanges();
        }

        /// <summary>
        /// Gets a book copy with the matching <paramref name="id"/>
        /// </summary>
        /// <param name="id">Id of the book</param>
        /// <returns>LINQ query containing the copies of a book</returns>
        public IQueryable<BookCopy> GetByBookId(int id)
        {
            var query = from bc in Entities
                        where bc.IdBook == id
                        select bc;
            return query;
        } 
    }
}
