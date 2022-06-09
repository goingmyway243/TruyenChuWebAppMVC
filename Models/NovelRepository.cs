using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class NovelRepository
    {
        public IEnumerable<NovelModel> novels { get; set; }

        public NovelModel GetNovelById(int id)
        {
            return novels.FirstOrDefault(novel => novel.id == id);
        }
    }
}
