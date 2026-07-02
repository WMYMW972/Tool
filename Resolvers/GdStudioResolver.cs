using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace tool.Resolvers
{
    public class GdStudioResolver : IMusicResolver
    {
        private readonly HttpClient _httpClient;
        private bool _isAvailable = true;

        public string Name => "GdStudio";
        public bool IsAvailable => _isAvailable;

        public GdStudioResolver()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
            _httpClient.Timeout = TimeSpan.FromSeconds(15);
        }

        public async Task<string> GetSongUrl(string songId, int quality = 320)
        {
            try
            {
                string br = quality >= 999 ? "999" : quality >= 320 ? "320" : "128";
                string url = $"https://music-api.gdstudio.xyz/api.php?types=url&source=netease&id={songId}&br={br}";

                var response = await _httpClient.GetStringAsync(url);
                var json = JObject.Parse(response);
                string result = json["url"]?.ToString() ?? "";

                if (!string.IsNullOrEmpty(result))
                    return result;

                _isAvailable = false;
                return "";
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
                string url = $"https://music-api.gdstudio.xyz/api.php?types=search&source=netease&name={encodedKeyword}&count=30";

                var response = await _httpClient.GetStringAsync(url);
                var array = JArray.Parse(response);

                foreach (var item in array)
                {
                    string name = item["name"]?.ToString() ?? "";

                    string artist = "";
                    var artistToken = item["artist"];
                    if (artistToken != null)
                    {
                        if (artistToken.Type == JTokenType.Array)
                        {
                            var firstArtist = artistToken.FirstOrDefault();
                            artist = firstArtist?.ToString() ?? "";
                        }
                        else
                        {
                            artist = artistToken.ToString();
                        }
                    }

                    string album = item["album"]?.ToString() ?? "";
                    string duration = item["duration"]?.ToString() ?? "";

                    // 清理数据
                    artist = CleanText(artist);
                    album = CleanText(album);

                    if (string.IsNullOrEmpty(name) || name.Length < 2)
                        continue;

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
            catch { }
            return result;
        }

        // 辅助方法：清理文本中的括号和引号（静态方法）
        private static string CleanText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            // 去掉 JSON 数组格式：["Michael Jackson"] → Michael Jackson
            if (text.StartsWith("[\"") && text.EndsWith("\"]"))
            {
                text = text.Substring(2, text.Length - 4);
            }
            // 去掉普通括号：[Michael Jackson] → Michael Jackson
            else if (text.StartsWith("[") && text.EndsWith("]"))
            {
                text = text.Substring(1, text.Length - 2);
            }

            // 去掉多余的引号
            text = text.Replace("\"", "");

            return text.Trim();
        }
    }
}