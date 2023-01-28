﻿using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class BookCopyService
    {
        

        public bool AddBookCopy(BookCopy bookCopy)
        {
            using(var repo = new BookCopyRepository())
            {
                var num = repo.Add(bookCopy);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public bool UpdateBookCopy(BookCopy bookCopy)
        {
            using (var repo = new BookCopyRepository())
            {
                var num = repo.Update(bookCopy);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public bool DeleteBookCopy(BookCopy bookCopy)
        {
            using (var repo = new BookCopyRepository())
            {
                var num = repo.Delete(bookCopy);
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public List<BookCopy> GetBookCopies()
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopies = repo.GetAll();
                return bookCopies.ToList();
            }

        }

        public List<BookCopy> GetBookCopyById(int id)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetById(id);
                return bookCopy.ToList();
            }

        }

        public List<BookCopy> GetBookCopiesByBookId(int id)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetByBookId(id);
                return bookCopy.ToList();
            }

        }


    }
}
