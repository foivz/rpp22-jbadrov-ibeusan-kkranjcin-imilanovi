using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class AuthorService
    {
        /// <summary>
        /// Gets all authors
        /// </summary>
        /// <returns>List of <see cref="Author"/> objects</returns>
        public List<Author> GetAuthors()
        {
            using(var repo = new AuthorRepository())
            {
                var authors = repo.GetAll();
                return authors.ToList();
            }
        }

        /// <summary>
        /// Adds the <paramref name="author"/> into the database
        /// </summary>
        /// <param name="author">Author intended for adding into the database</param>
        /// <returns><see langword="True"/> if author was added successfully, <see langword="False"/> if problem occurred</returns>
        public bool AddAuthor(Author author)
        {
            using (var repo = new AuthorRepository()) 
            {
                var num = repo.Add(author);
                if(num > 0)
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
