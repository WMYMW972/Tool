using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
                string url = $"https://music-api.gdstudio.xyz/api.php?types=search&source=netease&name={keyword}&count=30";

                var response = await _httpClient.GetStringAsync(url);
                var array = JArray.Parse(response);

                foreach (var item in array)
                {
                    result.Add(new SongInfo
                    {
                        Id = item["id"]?.ToString() ?? "",
                        Name = item["name"]?.ToString() ?? "未知歌曲",
                        Artist = item["artist"]?.ToString() ?? "未知歌手",
                        Album = item["album"]?.ToString() ?? "",
                        Duration = item["duration"]?.ToString() ?? ""
                    });
                }
            }
            catch { }
            return result;
        }
    }
}