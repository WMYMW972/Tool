using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tool
{
    public class MusicResolverManager
    {
        // ==================== 字段定义（只定义一次） ====================
        private readonly List<IMusicResolver> _resolvers;
        private readonly Dictionary<string, int> _failCount = new Dictionary<string, int>();
        private const int MAX_FAIL_COUNT = 3;

        // ==================== 构造函数 ====================
        public MusicResolverManager()
        {
            _resolvers = new List<IMusicResolver>
            {
                new Resolvers.GdStudioResolver(),      // 主解析源
                new Resolvers.NeteaseApiResolver()     // 备选解析源
            };
        }

        // ==================== 获取歌曲URL ====================
        public async Task<string> GetSongUrl(string songId, int quality = 320)
        {
            var sorted = _resolvers
                .Where(r => r.IsAvailable)
                .OrderBy(r => _failCount.ContainsKey(r.Name) ? _failCount[r.Name] : 0)
                .ToList();

            if (sorted.Count == 0)
                return "";

            foreach (var resolver in sorted)
            {
                try
                {
                    string url = await resolver.GetSongUrl(songId, quality);
                    if (!string.IsNullOrEmpty(url))
                    {
                        _failCount[resolver.Name] = 0;
                        return url;
                    }
                    else
                    {
                        if (!_failCount.ContainsKey(resolver.Name))
                            _failCount[resolver.Name] = 0;
                        _failCount[resolver.Name]++;
                    }
                }
                catch
                {
                    if (!_failCount.ContainsKey(resolver.Name))
                        _failCount[resolver.Name] = 0;
                    _failCount[resolver.Name]++;
                }
            }

            return "";
        }

        // ==================== 搜索歌曲 ====================
        public async Task<List<SongInfo>> Search(string keyword)
        {
            // 先尝试 GdStudio（英文/中文效果好）
            foreach (var resolver in _resolvers)
            {
                if (!resolver.IsAvailable) continue;
                try
                {
                    var result = await resolver.Search(keyword);
                    if (result != null && result.Count > 0)
                        return result;
                }
                catch { }
            }
            return new List<SongInfo>();
        }

        // ==================== 获取状态 ====================
        public string GetStatus()
        {
            return string.Join("\n", _resolvers.Select(r =>
                $"{r.Name}: {(r.IsAvailable ? "可用" : "不可用")} " +
                $"({(_failCount.ContainsKey(r.Name) ? _failCount[r.Name] : 0)}次失败)"
            ));
        }
    }
}