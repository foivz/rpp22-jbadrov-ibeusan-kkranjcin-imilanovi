using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class GenreService
    {
        /// <summary>
        /// Gets all genres
        /// </summary>
        /// <returns>List of <see cref="Genre"/> objects</returns>
        public List<Genre> GetGenres()
        {
            using(var repo = new GenreRepository())
            {
                var genres = repo.GetAll();
                return genres.ToList();
            }
        } 
    }
}
