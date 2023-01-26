using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class BookService
    {
        public bool AddBook(Book book)
        {
            using (var repo = new BookRepository())
            {
                var num = repo.Add(book);
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

        public bool UpdateBook(Book book)
        {
            using (var repo = new BookRepository())
            {
                var num = repo.Update(book);
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

        public bool DeleteBook(Book book)
        {
            using (var repo = new BookRepository())
            {
                var num = repo.Delete(book);
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

        public List<Book> GetBooks()
        {
            using (var repo = new BookRepository())
            {
                var book = repo.GetAll();
                return book.ToList();
            }
        }

        public List<Book> GetBookById(int id)
        {
            using (var repo = new BookRepository())
            {
                var book = repo.GetBookById(id);
                return book.ToList();
            }
        }

        public List<Book> GetBooksByTitle(string title)
        {
            using (var repo = new BookRepository())
            {
                var book = repo.GetBooksByTitle(title);
                return book.ToList();
            }
        }

        public List<Book> GetBooksByAuthors(string author)
        {
            using (var repo = new BookRepository())
            {
                var book = repo.GetBooksByAuthors(author);
                return book.ToList();
            }
        }

        public List<Book> GetBooksByGenre(string genre)
        {
            using (var repo = new BookRepository())
            {
                var book = repo.GetBooksByGenre(genre);
                return book.ToList();
            }
        }
    }
}
