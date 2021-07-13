namespace BotReborn.Model.Message.Element
{
    public class GroupImageElement
    {
        public string ImageId { get; set; }
        public int FileId { get; set; }
        public int ImageType { get; set; }
        public int Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public byte[] Md5 { get; set; }
        public string Url { get; set; }
    }

    public class GroupFlashPicElement : GroupImageElement { }

    public class GroupShowPicElement : GroupImageElement
    {
        public int EffectId { get; set; }
    }
}