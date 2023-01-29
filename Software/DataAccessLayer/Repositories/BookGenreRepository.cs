using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BookGenreRepository : Repository<BookGenre>
    {
        public BookGenreRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> of type <see cref="BookGenre"/> into the database
        /// </summary>
        /// <param name="entity">Genre of the book intended for adding into the database</param>
        /// <returns>1 if adding the genre of the book was successful, 0 if not</returns>
        public override int Add(BookGenre entity)
        {
            var bookGenre = new BookGenre
            {
                IdBook = entity.IdBook,    
                IdGenre = entity.IdGenre
            };

            Entities.Add(bookGenre);
            return SaveChanges();
        }
    }
}
