using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Controllers
{
    public class ChapterController : Controller
    {
        [Route("chapter/{chapterId}")]
        public IActionResult Index(int chapterId)
        {
            return View();
        }
    }
}
