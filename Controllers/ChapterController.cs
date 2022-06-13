using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruyenChuWebAppMVC.Models;
using TruyenChuWebAppMVC.Utils;

namespace TruyenChuWebAppMVC.Controllers
{
    public class ChapterController : Controller
    {
        private ChapterModel _chapterModel { get; set; }

        [Route("chapter/{chapterId}")]
        public IActionResult Index(int chapterId, int viewId)
        {
            _chapterModel = CallAPI.GetChapterById(chapterId, true);

            NovelModel novel = _chapterModel.novel;
            CallAPI.AttachChaptersByNovel(ref novel);
            _chapterModel.novel = novel;

            _chapterModel.view_id = viewId;
            
            return View(_chapterModel);
        }
    }
}
