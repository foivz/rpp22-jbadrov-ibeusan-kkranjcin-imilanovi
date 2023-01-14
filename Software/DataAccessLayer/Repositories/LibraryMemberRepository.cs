using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LibraryMemberRepository : Repository<LibraryMember>
    {
        public LibraryMemberRepository() : base(new RPP22_07_DBEntities())
        {
        }

        public override IQueryable<LibraryMember> GetAll()
        {
            var query = from lm in Entities
                        select lm;
            return query;
        }

        public IQueryable<LibraryMember> GetById(int id)
        {
            var query = from lm in Entities
                        where lm.Id == id
                        select lm;
            return query;
        }

        public override int Add(LibraryMember entity)
        {
            var libraryMember = new LibraryMember()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email
            };

            Entities.Add(libraryMember);
            return SaveChanges();
        }

        public override int Update(LibraryMember entity)
        {
            var libraryMember = Entities.SingleOrDefault(lm => lm.Id == entity.Id);
            libraryMember.FirstName = entity.FirstName;
            libraryMember.LastName = entity.LastName;
            libraryMember.Email = entity.Email;

            return SaveChanges();
        }
    }
}
