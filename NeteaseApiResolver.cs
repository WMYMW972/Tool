using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace tool.Resolvers
{
    /// <summary>
    /// 解析源2: 直接调用网易云API（VIP歌曲可能失败，但作为备选）
    /// </summary>
    public class NeteaseApiResolver : IMusicResolver
    {
        private readonly HttpClient _httpClient;
        private bool _isAvailable = true;

        public string Name => "NeteaseAPI";
        public bool IsAvailable => _isAvailable;

        public NeteaseApiResolver()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
            _httpClient.Timeout = TimeSpan.FromSeconds(15);
        }

        public async Task<string> GetSongUrl(string songId, string platform, int quality = 320)
        {
            try
            {
                if (platform != "网易云") return "";

                // 方式1: GET请求
                string url = $"https://music.163.com/api/song/enhance/player/url?id={songId}&ids=[{songId}]&br={quality * 1000}";

                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
                _httpClient.DefaultRequestHeaders.Add("Referer", "https://music.163.com");
                _httpClient.DefaultRequestHeaders.Add("Cookie", "os=pc; appver=2.9.8;");

                var response = await _httpClient.GetStringAsync(url);
                var obj = JObject.Parse(response);
                string result = obj["data"]?[0]?["url"]?.ToString() ?? "";

                if (!string.IsNullOrEmpty(result))
                    return result;

                // 方式2: POST请求
                return await GetNeteaseUrlPost(songId, quality);
            }
            catch
            {
                _isAvailable = false;
                return "";
            }
        }

        private async Task<string> GetNeteaseUrlPost(string songId, int quality)
        {
            try
            {
                string url = "https://music.163.com/api/song/enhance/player/url";
                var data = new { ids = new[] { songId }, br = quality * 1000 };
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
                _httpClient.DefaultRequestHeaders.Add("Referer", "https://music.163.com");
                _httpClient.DefaultRequestHeaders.Add("Cookie", "os=pc; appver=2.9.8;");

                var response = await _httpClient.PostAsync(url, content);
                string json = await response.Content.ReadAsStringAsync();

                var obj = JObject.Parse(json);
                return obj["data"]?[0]?["url"]?.ToString() ?? "";
            }
            catch
            {
                return "";
            }
        }

        public async Task<List<SongInfo>> Search(string keyword, string platform)
        {
            // 这个解析源只负责获取URL，搜索使用主解析源
            return new List<SongInfo>();
        }

        public Task<string> GetSongUrl(string songId, int quality = 320)
        {
            throw new NotImplementedException();
        }

        public Task<List<SongInfo>> Search(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}