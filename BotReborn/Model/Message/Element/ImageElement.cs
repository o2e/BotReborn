namespace BotReborn.Model.Message.Element {
    public class ImageElement {
        public string Filename { get; set; }
        public int Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Url { get; set; }
        public byte[] Md5 { get; set; }
        public byte[] Data { get; set; }
    }
    public class GroupFlashImgElement : ImageElement { }

    public class FriendFlashImgElement : ImageElement { }

    public class FriendFlashPicElement : FriendFlashImgElement { }
}