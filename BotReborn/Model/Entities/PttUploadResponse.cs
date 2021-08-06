namespace BotReborn.Model.Entities
{
    public struct PttUploadResponse
    {
        public int ResultCode { get; set; }
        public string Message { get; set; }
        public bool IsExists { get; set; }
        public string ResourceId { get; set; }
        public byte[] UploadKey { get; set; }
        public string[] UploadIp { get; set; }
        public int[] UploadPort { get; set; }
        public byte[] FileKey { get; set; }
        public long FileId { get; set; }
    }
}
