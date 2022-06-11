using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TruyenChuWebAppMVC.Models;

namespace TruyenChuWebAppMVC.Utils
{
    public static class CallAPI
    {
        private static HttpClient _client;
        private static HttpResponseMessage _response;

        private static void Initialize()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost/api/truyenchu/");
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static void AttachChaptersByNovelId(ref NovelRepository novelRepo)
        {
            var chapterRepository = GetChapterRepository();

            foreach (var item in novelRepo.novels)
            {
                item.chapters = chapterRepository.GetListChapterByNovelId(item.id).ToList();
            }
        }

        public static void AttachChaptersByNovelId(ref NovelModel novel)
        {
            var chapterRepository = GetChapterRepository();
            novel.chapters = chapterRepository.GetListChapterByNovelId(novel.id).ToList();
        }

        public static void AttachAuthorByNovelId(ref NovelModel novel)
        {
            var authorRepository = GetAuthorRepository();
            novel.author = authorRepository.GetAuthorById(novel.id_author);
        }

        public static void AttachGenresByNovelId(ref NovelModel novel)
        {
            var listGenre = GetListGenreByNovelId(novel.id);
            novel.genres = listGenre.genres.ToList();
        }

        public static void AttachUserByNovelId(ref NovelModel novel)
        {
            var userRepository = GetUserRepository();
            novel.user = userRepository.GetUserById(novel.id_user);
        }

        public static UserRepository GetUserRepository()
        {
            var task = GetUserRepositoryTask();
            task.Wait();
            return task.Result;
        }

        public static AuthorRepository GetAuthorRepository()
        {
            var task = GetAuthorRepositoryTask();
            task.Wait();
            return task.Result;
        }

        public static GenreRepository GetGenreRepository()
        {
            var task = GetGenreRepositoryTask();
            task.Wait();
            return task.Result;
        }

        public static NovelRepository GetNovelRepository()
        {
            var task = GetNovelRepositoryTask();
            task.Wait();
            return task.Result;
        }

        public static ChapterRepository GetChapterRepository()
        {
            var task = GetChapterRepositoryTask();
            task.Wait();
            return task.Result;
        }

        public static NovelModel GetNovelById(int id, bool attachFullInfo = false)
        {
            var task = GetNovelByIdTask(id);
            task.Wait();

            NovelModel novel = task.Result;
            
            if(attachFullInfo)
            {
                AttachChaptersByNovelId(ref novel);
                AttachAuthorByNovelId(ref novel);
                AttachGenresByNovelId(ref novel);
                AttachUserByNovelId(ref novel);
            }

            return novel;
        }

        public static GenreRepository GetListGenreByNovelId(int novelId)
        {
            var task = GetListGenreByNovelIdTask(novelId);
            task.Wait();
            return task.Result;
        }

        private static async Task<UserRepository> GetUserRepositoryTask()
        {
            if (_client == null)
            {
                Initialize();
            }

            _response = await _client.GetAsync("get_user.php");

            var result = await _response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<UserRepository>(result);

            return list;
        }

        private static async Task<AuthorRepository> GetAuthorRepositoryTask()
        {
            if (_client == null)
            {
                Initialize();
            }

            _response = await _client.GetAsync("get_author.php");

            var result = await _response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<AuthorRepository>(result);

            return list;
        }

        private static async Task<GenreRepository> GetGenreRepositoryTask()
        {
            if (_client == null)
            {
                Initialize();
            }

            _response = await _client.GetAsync("get_genre.php");

            var result = await _response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<GenreRepository>(result);

            return list;
        }

        private static async Task<NovelRepository> GetNovelRepositoryTask()
        {
            if(_client == null)
            {
                Initialize();
            }

            _response = await _client.GetAsync("get_newest_novel.php");

            var result = await _response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<NovelRepository>(result);

            return list;
        }

        private static async Task<ChapterRepository> GetChapterRepositoryTask()
        {
            if (_client == null)
            {
                Initialize();
            }

            _response = await _client.GetAsync("get_chapter.php");

            string result = await _response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<ChapterRepository>(result);

            return list;
        }

        private static async Task<NovelModel> GetNovelByIdTask(int id)
        {
            if (_client == null)
            {
                Initialize();
            }

            var parameter = new Dictionary<string, string>()
            {
                {"ID", id +"" }
            };

            var postParams = new FormUrlEncodedContent(parameter);

            _response = await _client.PostAsync("get_novel_by_id.php", postParams);

            string result = await _response.Content.ReadAsStringAsync();
            
            if(result.Contains("Error"))
            {
                return null;
            }

            var novel = JsonConvert.DeserializeObject<NovelModel>(result);

            return novel;
        }

        private static async Task<GenreRepository> GetListGenreByNovelIdTask(int novelId)
        {
            if (_client == null)
            {
                Initialize();
            }

            var parameter = new Dictionary<string, string>()
            {
                {"IDNovel", novelId +"" }
            };

            var postParams = new FormUrlEncodedContent(parameter);

            _response = await _client.PostAsync("get_genre_by_idnovel.php", postParams);

            string result = await _response.Content.ReadAsStringAsync();

            if (result.Contains("Error"))
            {
                return null;
            }

            var list = JsonConvert.DeserializeObject<GenreRepository>(result);

            return list;
        }
    }
}
