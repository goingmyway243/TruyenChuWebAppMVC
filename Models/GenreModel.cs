using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class GenreModel
    {
        public int id { get; set; }
        public string genre_name { get; set; }

        public List<NovelModel> novels { get; set; }
    }
}
