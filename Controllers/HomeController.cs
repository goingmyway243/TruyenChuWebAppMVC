using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TruyenChuWebAppMVC.Models;
using TruyenChuWebAppMVC.Utils;

namespace TruyenChuWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private NovelRepository _novelRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _novelRepository = CallAPI.GetNovelRepository();
            CallAPI.AttachChaptersByNovel(ref _novelRepository);

            return View(_novelRepository);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(UserModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var loginUser = CallAPI.Login(user);

            if(loginUser == null)
            {
                ModelState.AddModelError(nameof(user.loginState), "Tài khoản hoặc mật khẩu không đúng!");
                return View(user);
            }

            return RedirectToAction("Index");
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            _novelRepository = CallAPI.GetNovelRepository();
            _novelRepository.novels = _novelRepository.novels.Where(novel => novel.title.ToLower().Contains(keyword.ToLower()));
            CallAPI.AttachChaptersByNovel(ref _novelRepository);
            return View(_novelRepository);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
