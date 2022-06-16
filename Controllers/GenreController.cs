using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruyenChuWebAppMVC.Models;
using TruyenChuWebAppMVC.Utils;

namespace TruyenChuWebAppMVC.Controllers
{
    public class GenreController : Controller
    {
        private GenreRepository _genreRepository;
        private GenreModel _genreModel;
        public IActionResult Index()
        {
            _genreRepository = CallAPI.GetGenreRepository();
            return View(_genreRepository);
        }

        [Route("Genre/{genreId}")]
        public IActionResult Genre(int genreId)
        {
            _genreModel = CallAPI.GetGenreById(genreId, true);

            var novelRepository = new NovelRepository();
            novelRepository.novels = _genreModel.novels;
            CallAPI.AttachChaptersByNovel(ref novelRepository);

            _genreModel.novels = novelRepository.novels.ToList();
            _genreModel.novels.OrderByDescending(novel => novel.date_post).ToList();

            return View(_genreModel);
        }
    }
}
