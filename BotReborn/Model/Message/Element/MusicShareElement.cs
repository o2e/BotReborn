namespace BotReborn.Model.Message.Element
{
    /// <summary>
    /// MusicShareElement 音乐分享卡片
    /// 请使用 SendGroupMusicShare 或者 SendFriendMusicShare 发送
    /// </summary>
    public class MusicShareElement
    {
        public int MusicType { get; set; }    // 音乐类型,请使用 QQMusic 等常量
        public string Title { get; set; } // 标题(歌曲名)
        public string Brief { get; set; }
        public string Summary { get; set; } // 简介(歌手名)
        public string Url { get; set; } // 点击跳转链接
        public string PictureUrl { get; set; } // 显示图片链接
        public string MusicUrl { get; set; } // 音乐播放链接
    }
}
