using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BookAuthorRepository : Repository<BookAuthor>
    {
        public BookAuthorRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> of type <see cref="BookAuthor"/> into the database
        /// </summary>
        /// <param name="entity">Author of the book intended for adding into the database</param>
        /// <returns>1 if adding the author of the book was successful, 0 if not</returns>
        public override int Add(BookAuthor entity)
        {
            var bookAuthor = new BookAuthor
            {
                IdBook = entity.IdBook,
                IdAuthor = entity.IdAuthor
            };

            Entities.Add(bookAuthor);
            return SaveChanges();
        }
    }
}
