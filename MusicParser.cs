using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tool
{
    public class MusicParser
    {
        private readonly HttpClient _httpClient;
        private readonly MusicResolverManager _resolverManager;

        public MusicParser()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
            _resolverManager = new MusicResolverManager();
        }

        public async Task<List<SongInfo>> Search(string keyword)
        {
            return await _resolverManager.Search(keyword);
        }

        public async Task<string> GetDownloadUrl(SongInfo song, int quality = 320)
        {
            return await _resolverManager.GetSongUrl(song.Id, quality);
        }

        public async Task<string> DownloadSong(string saveFolder, SongInfo song, string downloadUrl)
        {
            if (string.IsNullOrEmpty(downloadUrl))
                throw new Exception("没有获取到下载地址");

            string fileName = $"{song.Name} - {song.Artist}";
            string safeName = SanitizeFileName(fileName);
            string filePath = Path.Combine(saveFolder, $"{safeName}.mp3");

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
                client.DefaultRequestHeaders.Add("Referer", "https://music.163.com");

                var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();

                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    await response.Content.CopyToAsync(fs);
                }
            }

            return filePath;
        }

        public string GetResolverStatus()
        {
            return _resolverManager.GetStatus();
        }

        private string SanitizeFileName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return "unknown";

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }
            return name.Trim();
        }
    }

    public class SongInfo
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Album { get; set; } = "";
        public string Duration { get; set; } = "";

        public override string ToString()
        {
            // ========== 显示：歌曲名 - 歌手名 [专辑] ==========
            if (!string.IsNullOrEmpty(Album))
            {
                // 专辑名如果太长，截断一下
                string albumDisplay = Album.Length > 20 ? Album.Substring(0, 20) + "..." : Album;
                return $"{Name} - {Artist}  [{albumDisplay}]";
            }
            return $"{Name} - {Artist}";
        }

        public string GetFullInfo()
        {
            string info = $"歌曲: {Name}";
            if (!string.IsNullOrEmpty(Artist))
                info += $"\n歌手: {Artist}";
            if (!string.IsNullOrEmpty(Album))
                info += $"\n专辑: {Album}";
            if (!string.IsNullOrEmpty(Duration))
            {
                // 时长格式转换（毫秒 → 分:秒）
                if (int.TryParse(Duration, out int ms))
                {
                    int totalSeconds = ms / 1000;
                    int minutes = totalSeconds / 60;
                    int seconds = totalSeconds % 60;
                    info += $"\n时长: {minutes:D2}:{seconds:D2}";
                }
                else
                {
                    info += $"\n时长: {Duration}";
                }
            }
            return info;
        }
    }
}