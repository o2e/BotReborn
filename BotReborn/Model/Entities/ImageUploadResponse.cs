namespace BotReborn.Model.Entities
{
    public struct ImageUploadResponse
    {
        public byte[] UploadKey { get; set; }
        public uint[] UploadIp { get; set; }
        public uint[] UploadPort { get; set; }
        public string ResourceId { get; set; }
        public string Message { get; set; }
        public long FileId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int ResultCode { get; set; }
        public bool IsExists { get; set; }
    }
}
