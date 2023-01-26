﻿using System;
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
            var query = from b in Entities.Include("Publisher").Include("Book")
                        select b;
            return query;
        }

        public IQueryable<BookCopy> GetBookCopyById(int id)
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
                IdPublisher = entity.IdPublisher,
                IdBook = entity.IdBook,
                YearOfPublication = entity.YearOfPublication,
                Language = entity.Language
            };

            Entities.Add(bookCopy);
            return SaveChanges();
        }

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
    }
}
