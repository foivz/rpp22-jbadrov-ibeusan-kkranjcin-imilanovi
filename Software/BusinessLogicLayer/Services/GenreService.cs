using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services
{
    public class GenreService
    {
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
