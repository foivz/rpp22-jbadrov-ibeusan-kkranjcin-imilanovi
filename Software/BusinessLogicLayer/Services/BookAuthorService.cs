using DataAccessLayer.Repositories;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.Services
{
    public class BookAuthorService
    {
        /// <summary>
        /// Adds the <paramref name="bookAuthor"/> into the database
        /// </summary>
        /// <param name="bookAuthor">Author of the book intended for adding into the database</param>
        /// <returns><see langword="True"/> if bookAuthor was added successfully, <see langword="False"/> if problem occurred</returns>
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

        /// <summary>
        /// Deletes the <paramref name="bookAuthor"/> from the database
        /// </summary>
        /// <param name="bookAuthor">Author of the book intended for deleting from the database</param>
        /// <returns><see langword="True"/> if delete is successful, <see langword="False"/> if not</returns>
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
