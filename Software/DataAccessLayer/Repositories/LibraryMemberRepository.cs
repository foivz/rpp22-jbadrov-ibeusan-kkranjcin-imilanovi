using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class LibraryMemberRepository : Repository<LibraryMember>
    {
        public LibraryMemberRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Gets all library members from DB
        /// </summary>
        /// <returns>LINQ query containing all library members</returns>
        public override IQueryable<LibraryMember> GetAll()
        {
            var query = from lm in Entities
                        select lm;
            return query;
        }

        /// <summary>
        /// Gets a library member with the matching <paramref name="id"/>
        /// </summary>
        /// <param name="id">Id of the targeted member</param>
        /// <returns>LINQ query containing the library member</returns>
        public IQueryable<LibraryMember> GetById(int id)
        {
            var query = from lm in Entities
                        where lm.Id == id
                        select lm;
            return query;
        }

        /// <summary>
        /// Adds the <paramref name="entity"/> library member into the DB
        /// </summary>
        /// <param name="entity">The library member intended for adding into the database</param>
        /// <returns>1 if add is successful, 0 if not</returns>
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

        /// <summary>
        /// Updates the <paramref name="entity"/> library member in the DB
        /// </summary>
        /// <param name="entity">The library member intended for updating in the database</param>
        /// <returns>1 if update is successful, 0 if not</returns>
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
