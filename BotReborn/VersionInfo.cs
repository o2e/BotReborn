namespace BotReborn
{
    public struct VersionInfo
    {
        public byte[] ApkSign { get; set; }
        public string ApkId { get; set; }
        public string SortVersionName { get; set; }
        public string SdkVersion { get; set; }
        public uint AppId { get; set; }
        public uint SubAppId { get; set; }
        public uint BuildTime { get; set; }
        public uint SSOVersion { get; set; }
        public uint MiscBitmap { get; set; }
        public uint SubSigmap { get; set; }
        public uint MainSigMap { get; set; }
        public ClientProtocol Protocol { get; set; }
    }
}
