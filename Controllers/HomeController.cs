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

namespace TruyenChuWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HttpClient _client;
        private HttpResponseMessage _response;
        private Novels _model;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost/api/truyenchu/");
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IActionResult Index()
        {
            var task = GetNovelList();
            task.Wait();
            _model = task.Result;
            
            for(int i=0;i<_model.novels.Count;i++)
            {
                var getTask = GetChapterList(_model.novels[i].id);
                getTask.Wait();
                var result = getTask.Result;

                _model.novels[i].chapters = result.chapters;
            }

            return View(_model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<Novels> GetNovelList()
        {
            _response = await _client.GetAsync("get_newest_novel.php");

            var result = await _response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<Novels>(result);

            return list;
        }

        public async Task<Chapters> GetChapterList(int id)
        {
            var values = new Dictionary<string, string>()
            {
                {"IDNovel", id.ToString() }
            };

            var postParams = new FormUrlEncodedContent(values);

            _response = await _client.PostAsync("get_chapter_by_idnovel.php", postParams);

            string result = await _response.Content.ReadAsStringAsync();
            if(result.Contains("Undefined variable"))
            {
                return new Chapters();
            }
            var list = JsonConvert.DeserializeObject<Chapters>(result);

            return list;
        }
    }
}
