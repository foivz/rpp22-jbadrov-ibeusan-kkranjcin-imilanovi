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

        public override IQueryable<BookCopy> GetAll()
        {
            var query = from b in Entities
                        select b;
            return query;
        }

        public IQueryable<BookCopy> GetBookById(int id)
        {
            var query = from b in Entities
                        where b.Id == id
                        select b;
            return query;
        }

        public override int Add(BookCopy entity)
        {
            var bookCopy = new BookCopy
            {
                Edition = entity.Edition,
                Publisher = entity.Publisher,
                Book = entity.Book,
                YearOfPublication = entity.YearOfPublication,
                //ISBN = entity.ISBN,
                Language = entity.Language
            };

            Entities.Add(bookCopy);
            return SaveChanges();
        }

        public override int Update(BookCopy entity)
        {
            var bookCopy = Entities.SingleOrDefault(a => a.Id == entity.Id);
            bookCopy.Edition = entity.Edition;
            bookCopy.Publisher = entity.Publisher;
            bookCopy.Book = entity.Book;
            bookCopy.YearOfPublication = entity.YearOfPublication;
            //bookCopy.ISBN = entity.ISBN;
            bookCopy.Language = entity.Language;

            return SaveChanges();
        }
    }
}
