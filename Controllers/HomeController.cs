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
        private static UserModel _userModel;

        public static UserModel UserModel { get => _userModel; }

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

        public IActionResult About()
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
            if (user.id == null || user.pass == null)
            {
                return View(user);
            }

            var loginUser = CallAPI.Login(user);

            if (loginUser == null)
            {
                ModelState.AddModelError(nameof(user.validation), "Tài khoản hoặc mật khẩu không đúng!");
                return View(user);
            }

            _userModel = loginUser;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel user)
        {
            if (ModelState.IsValid)
            {
                if (user.pass != user.retypePass)
                {
                    ModelState.AddModelError(nameof(user.retypePass), "Mật khẩu nhập lại không đúng!");
                    return View(user);
                }

                var userRepo = CallAPI.GetUserRepository();

                var check = userRepo.GetUserById(user.id);

                if (check != null)
                {
                    ModelState.AddModelError(nameof(user.validation), "Tài khoản đã tồn tại!");
                    return View(user);
                }

                check = userRepo.GetUserByEmail(user.email);
                if (check != null)
                {
                    ModelState.AddModelError(nameof(user.validation), "Email đã được đăng ký!");
                    return View(user);
                }

                user.id_role = 2;

                if (!CallAPI.APIUser(user, "insert"))
                {
                    ModelState.AddModelError(nameof(user.validation), "Đăng ký thất bại!");
                    return View(user);
                }

                _userModel = user;

                return RedirectToAction("SignIn");
            }
            return View(user);
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
