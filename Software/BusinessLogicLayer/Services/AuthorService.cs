using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class AuthorService
    {

        public List<Author> GetAuthors()
        {
            using(var repo = new AuthorRepository())
            {
                var authors = repo.GetAll();
                return authors.ToList();
            }

        }
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

        public bool UpdateAuthor(Author author)
        {
            using (var repo = new AuthorRepository())
            {
                var num = repo.Update(author);
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

        public bool DeleteAuthor(Author author)
        {
            using (var repo = new AuthorRepository())
            {
                var num = repo.Delete(author);
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
