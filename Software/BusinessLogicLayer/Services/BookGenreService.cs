using DataAccessLayer.Repositories;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.Services
{
    public class BookGenreService
    {
        public List<BookGenre> GetBookGenreById(int id)
        {
            using (var repo = new BookGenreRepository())
            {
                var bookGenre = repo.GetBookGenreById(id);
                return bookGenre.ToList();
            }
        }

        public bool AddBookGenre(BookGenre bookGenre)
        {
            using (var repo = new BookGenreRepository())
            {
                var num = repo.Add(bookGenre);
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

        public bool DeleteBookGenre(BookGenre bookGenre)
        {
            using (var repo = new BookGenreRepository())
            {
                var num = repo.Delete(bookGenre);
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
