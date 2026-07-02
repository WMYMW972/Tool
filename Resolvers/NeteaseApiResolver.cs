using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<string> GetSongUrl(string songId, int quality = 320)
        {
            try
            {
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

                // 方式2: POST请求（备选）
                return await GetNeteaseUrlPost(songId, quality);
            }
            catch
            {
                _isAvailable = false;
                return "";
            }
        }

        public async Task<List<SongInfo>> Search(string keyword)
        {
            var result = new List<SongInfo>();
            try
            {
                string encodedKeyword = System.Web.HttpUtility.UrlEncode(keyword);
                string url = $"https://music.163.com/api/search/get/web?csrf_token=&s={encodedKeyword}&type=1&limit=30";

                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
                _httpClient.DefaultRequestHeaders.Add("Referer", "https://music.163.com");
                _httpClient.DefaultRequestHeaders.Add("Cookie", "os=pc; appver=2.9.8;");

                var response = await _httpClient.GetStringAsync(url);
                var json = JObject.Parse(response);

                int code = json["code"]?.Value<int>() ?? -1;
                if (code != 200)
                {
                    return result;
                }

                var songs = json["result"]?["songs"];
                if (songs != null)
                {
                    foreach (var item in songs)
                    {
                        string name = item["name"]?.ToString() ?? "";

                        string artist = "";
                        var artists = item["artists"] as JArray;
                        if (artists != null && artists.Count > 0)
                        {
                            artist = string.Join(", ", artists.Select(a => a["name"]?.ToString() ?? ""));
                        }

                        string album = item["album"]?["name"]?.ToString() ?? "";
                        string duration = item["duration"]?.ToString() ?? "";

                        if (string.IsNullOrEmpty(name) || name.Length < 2)
                            continue;

                        // 清理数据
                        artist = CleanText(artist);
                        album = CleanText(album);

                        result.Add(new SongInfo
                        {
                            Id = item["id"]?.ToString() ?? "",
                            Name = name,
                            Artist = artist,
                            Album = album,
                            Duration = duration
                        });
                    }
                }
            }
            catch
            {
                _isAvailable = false;
            }
            return result;
        }

        // 辅助方法：清理文本
        private string CleanText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            // 去掉 JSON 数组格式
            if (text.StartsWith("[\"") && text.EndsWith("\"]"))
            {
                text = text.Substring(2, text.Length - 4);
            }
            else if (text.StartsWith("[") && text.EndsWith("]"))
            {
                text = text.Substring(1, text.Length - 2);
            }

            text = text.Replace("\"", "");
            return text.Trim();
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
    }
}