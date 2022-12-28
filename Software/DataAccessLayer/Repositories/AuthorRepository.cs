using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AuthorRepository : Repository<Author>
    {
        public AuthorRepository() : base(new RPP22_07_DBEntities())
        {
        }

        public override IQueryable<Author> GetAll()
        {
            var query = from a in Entities
                        select a;
            return query;
        }

        public override int Add(Author entity)
        {
            var author = new Author
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DateOfBirth = entity.DateOfBirth
            };

            Entities.Add(author);
            return SaveChanges();
        }

        public override int Update(Author entity)
        {
            var author = Entities.SingleOrDefault(a => a.Id == entity.Id);
            author.FirstName = entity.FirstName;
            author.LastName = entity.LastName;
            author.DateOfBirth = entity.DateOfBirth;

            return SaveChanges();
        }

        public IQueryable<Author> GetAuthorByName(string name)
        {
            var split = name.Split(' ');
            IQueryable<Author> query = null;
            foreach(var item in split)
            {
                query.Concat(from a in Entities
                        where a.FirstName == item || a.LastName == item
                        select a);
               
            }

            return query;
        }
    }
}
