using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class BookService
    {
        /// <summary>
        /// Adds the <paramref name="book"/> into the database
        /// </summary>
        /// <param name="book">Book intended for adding into the database</param>
        /// <returns><see langword="True"/> if book was added successfully, <see langword="False"/> if problem occurred</returns>
        public bool AddBook(Book book)
        {
            CheckISBN(book.ISBN);
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

        /// <summary>
        /// Updates the <paramref name="book"/> in the database
        /// </summary>
        /// <param name="book">Book intended for updating in the database</param>
        /// <returns><see langword="True"/> if update is successful, <see langword="False"/> if not</returns>
        public bool UpdateBook(Book book)
        {
            CheckISBN(book.ISBN);
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

        /// <summary>
        /// Deletes the <paramref name="book"/> from the database
        /// </summary>
        /// <param name="book">Book intended for deleting from the database</param>
        /// <returns><see langword="True"/> if delete is successful, <see langword="False"/> if not</returns>
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

        /// <summary>
        /// Gets all books
        /// </summary>
        /// <returns>List of <see cref="Book"/> objects</returns>
        public List<Book> GetBooks()
        {
            using (var repo = new BookRepository())
            {
                var book = repo.GetAll();
                return book.ToList();
            }
        }

        /// <summary>
        /// Gets a book that matches given <paramref name="id"/>
        /// </summary>
        /// <returns>List of <see cref="Book"/> objects</returns>
        public List<Book> GetBookById(int id)
        {
            using (var repo = new BookRepository())
            {
                var book = repo.GetById(id);
                return book.ToList();
            }
        }

        /// <summary>
        /// Checks if given <paramref name="isbn"/> is written in right format and if it is not throws <see cref="Exception"/>
        /// </summary>
        private void CheckISBN(string isbn)
        {
            Regex regex = new Regex(@"^(97(8|9))?\d{9}(\d|X)$");
            Match match = regex.Match(isbn);
            if (!match.Success)
            {
                throw new Exception("ISBN must have 10 digits and start with 978 or 979!");
            }
        }
    }
}
