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

        public IQueryable<BookGenre> GetBookGenreById(int id)
        {
            var query = from g in Entities
                        where g.Id == id
                        select g;
            return query;
        }

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
