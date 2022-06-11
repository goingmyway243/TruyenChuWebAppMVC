using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class ChapterRepository
    {
        public IEnumerable<ChapterModel> chapters { get; set; }

        public ChapterModel GetChapterById(int id)
        {
            return chapters.FirstOrDefault(chapter => chapter.id == id);
        }

        public IEnumerable<ChapterModel> GetListChapterByNovelId(int novelId)
        {
            return chapters.Where(chapter => chapter.id_novel == novelId);
        }
    }
}
