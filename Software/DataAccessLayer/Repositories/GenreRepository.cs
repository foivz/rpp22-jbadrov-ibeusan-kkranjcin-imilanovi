using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class GenreRepository : Repository<Genre>
    {
        public GenreRepository() : base(new RPP22_07_DBEntities())
        {
        }

        /// <summary>
        /// Gets all genres from database
        /// </summary>
        /// <returns>LINQ query containing all genres</returns>
        public override IQueryable<Genre> GetAll()
        {
            var query = from g in Entities
                        select g;
            return query;
        }
    }
}
