using System;

namespace BotReborn.Model.Message.Element
{
    public class ShortVideoElement : IMessageElement
    {
        public string Name { get; set; }
        public byte[] Uuid { get; set; }
        public int Size { get; set; }
        public int ThumbSize { get; set; }
        public byte[] Md5 { get; set; }
        public string Url { get; set; }
        public ElementType Type() => ElementType.Video;
    }
}
