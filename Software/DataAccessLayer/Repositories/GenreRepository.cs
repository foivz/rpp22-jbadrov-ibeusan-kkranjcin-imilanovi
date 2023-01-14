using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenreRepository : Repository<Genre>
    {
        public GenreRepository() : base(new RPP22_07_DBEntities())
        {
        }

        public override IQueryable<Genre> GetAll()
        {
            var query = from g in Entities
                        select g;
            return query;
        }
    }
}
