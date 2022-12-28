using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenreRepository : Repository<Genre>
    {
        public GenreRepository(RPP22_07_DBEntities context) : base(context)
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
