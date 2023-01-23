using DataAccessLayer.Repositories;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class BookAuthorService
    {

        public List<BookAuthor> GetBookAuthorById(int id)
        {
            using (var repo = new BookAuthorRepository())
            {
                var bookAuthor = repo.GetBookAuthorById(id);
                return bookAuthor.ToList();
            }
        }

        public bool AddBookAuthor(BookAuthor bookAuthor)
        {
            using (var repo = new BookAuthorRepository())
            {
                var num = repo.Add(bookAuthor);
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

        public bool DeleteBookAuthor(BookAuthor bookAuthor)
        {
            using (var repo = new BookAuthorRepository())
            {
                var num = repo.Delete(bookAuthor);
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
    }
}
