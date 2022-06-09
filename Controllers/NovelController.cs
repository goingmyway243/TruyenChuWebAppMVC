using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruyenChuWebAppMVC.Models;
using TruyenChuWebAppMVC.Utils;

namespace TruyenChuWebAppMVC.Controllers
{
    public class NovelController : Controller
    {
        private NovelModel _novelModel;
        
        [Route("novel/{novelId}")]
        public IActionResult Index(int novelId)
        {
            _novelModel = CallAPI.GetNovelById(novelId);
            CallAPI.AttachChaptersByNovelId(ref _novelModel);
            return View(_novelModel);
        }

    }
}
