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

        public static NovelModel GetNovelById(int id)
        {
            var task = GetNovelByIdTask(id);
            task.Wait();
            return task.Result;
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
    }
}
