using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class ChapterModel
    {
        public int id { get; set; }
        public string title{ get; set; }
        public string content { get; set; }
        public string date_post { get; set; }
        public int id_novel { get; set; }
    }
}
