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

        public IQueryable<BookAuthor> GetBookAuthorById(int id)
        {
            var query = from a in Entities
                        where a.Id == id
                        select a;
            return query;
        }

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
