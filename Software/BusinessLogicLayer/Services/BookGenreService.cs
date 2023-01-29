using DataAccessLayer.Repositories;
using DataAccessLayer;

namespace BusinessLogicLayer.Services
{
    public class BookGenreService
    {
        /// <summary>
        /// Adds the <paramref name="bookGenre"/> into the database
        /// </summary>
        /// <param name="bookGenre">Genre of the book intended for adding into the database</param>
        /// <returns><see langword="True"/> if bookGenre was added successfully, <see langword="False"/> if problem occurred</returns>
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

        /// <summary>
        /// Deletes the <paramref name="bookGenre"/> from the database
        /// </summary>
        /// <param name="bookAuthor">Genre of the book intended for deleting from the database</param>
        /// <returns><see langword="True"/> if delete is successful, <see langword="False"/> if not</returns>
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
