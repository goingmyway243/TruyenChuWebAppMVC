using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class NovelModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public int id_author{ get; set; }
        public string description { get; set; }
        public string cover { get; set; }
        public string date_post { get; set; }
        public int view { get; set; }
        public string id_user { get; set; }

        public List<ChapterModel> chapters { get; set; }
        public List<GenreModel> genres { get; set; }
        public AuthorModel author{ get; set; }
        public UserModel user { get; set; }
    }
}
