using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class BookCopyService
    {
        /// <summary>
        /// Adds the <paramref name="bookCopy"/> into the database
        /// </summary>
        /// <param name="bookCopy"><see cref="BookCopy"/> intended for adding into the database</param>
        /// <returns><see langword="True"/> if copy of a book was added successfully, <see langword="False"/> if problem occurred</returns>
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

        /// <summary>
        /// Updates the <paramref name="bookCopy"/> in the database
        /// </summary>
        /// <param name="bookCopy"><see cref="BookCopy"/> intended for updating in the database</param>
        /// <returns><see langword="True"/> if update is successful, <see langword="False"/> if not</returns>
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

        /// <summary>
        /// Deletes the <paramref name="bookCopy"/> from the database
        /// </summary>
        /// <param name="bookCopy"><see cref="BookCopy"/> intended for deleting from the database</param>
        /// <returns><see langword="True"/> if delete is successful, <see langword="False"/> if not</returns>
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

        /// <summary>
        /// Gets all copies of the book
        /// </summary>
        /// <returns>List of <see cref="BookCopy"/> objects</returns>
        public List<BookCopy> GetBookCopies()
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopies = repo.GetAll();
                return bookCopies.ToList();
            }
        }

        /// <summary>
        /// Gets a copy of the book that matches given <paramref name="id"/>
        /// </summary>
        /// <returns>List of <see cref="BookCopy"/> objects</returns>
        public List<BookCopy> GetBookCopyById(int id)
        {
            using (var repo = new BookCopyRepository())
            {
                var bookCopy = repo.GetById(id);
                return bookCopy.ToList();
            }
        }

        /// <summary>
        /// Gets copies of a book that match given <paramref name="id"/> of a book
        /// </summary>
        /// <returns>List of <see cref="BookCopy"/> objects</returns>
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
