using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class GenreRepository
    {
        public IEnumerable<GenreModel> genres { get; set; }

        public GenreModel GetGenreById(int id)
        {
            return genres.FirstOrDefault(genre => genre.id == id);
        }
    }
}
