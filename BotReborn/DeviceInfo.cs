namespace BotReborn.Model
{
    public class DeviceInfo
    {
        public byte[] Display { get; set; }
        public byte[] Product { get; set; }
        public byte[] Device { get; set; }
        public byte[] Board { get; set; }
        public byte[] Brand { get; set; }
        public byte[] Model { get; set; }
        public byte[] Bootloader { get; set; }
        public byte[] FingerPrint { get; set; }
        public byte[] BootId { get; set; }
        public byte[] ProcVersion { get; set; }
        public byte[] BaseBand { get; set; }
        public byte[] SimInfo { get; set; }
        public byte[] OSType { get; set; }
        public byte[] MacAddress { get; set; }
        public byte[] IpAddress { get; set; }
        public byte[] WifiBSSID { get; set; }
        public byte[] WifiSSID { get; set; }
        public byte[] IMSIMd5 { get; set; }
        public string IMEI { get; set; }
        public byte[] AndroidId { get; set; }
        public byte[] APN { get; set; }
        public byte[] VendorName { get; set; }
        public byte[] VendorOSName { get; set; }
        public byte[] Guid { get; set; }
        public byte[] TgtgtKey { get; set; }
        public ClientProtocol Protocol { get; set; }
        public Version Version { get; set; }

        public static DeviceInfo Default { get; }

        static DeviceInfo()
        {
            Default = new DeviceInfo()
            {
                Display = Utils.GetBytes("BotReborn.114514.810"),
                Product = Utils.GetBytes("BotReborn"),
                Device = Utils.GetBytes("BotReborn"),
                Board = Utils.GetBytes("BotReborn"),
                Brand = Utils.GetBytes("BotReborn"),
                Model = Utils.GetBytes("BotReborn"),
                Bootloader = Utils.GetBytes("unknown"),
                FingerPrint = Utils.GetBytes("BotReborn:10/BotReborn.114514.810/114514:user/release-keys"),
                BootId = Utils.GetBytes("cb886ae2-00b6-4d68-a230-787f111d12c7"),
                ProcVersion = Utils.GetBytes("Linux version 3.0.31-cb886ae2 (android-build@xxx.xxx.xxx.xxx.com)"),
                BaseBand = System.Array.Empty<byte>(),
                SimInfo = Utils.GetBytes("T-Mobile"),
                OSType = Utils.GetBytes("android"),
                MacAddress = Utils.GetBytes("00:50:56:C0:00:08"),
                IpAddress = new byte[] {10, 0, 1, 3}, // 10.0.1.3
                WifiBSSID = Utils.GetBytes("00:50:56:C0:00:08"),
                WifiSSID = Utils.GetBytes("<unknown ssid>"),
                IMEI = "468356291846738",
                AndroidId = Utils.GetBytes("MIRAI.123456.001"),
                APN = Utils.GetBytes("wifi"),
                VendorName = Utils.GetBytes("MIUI"),
                VendorOSName = Utils.GetBytes("mirai"),
                Protocol = ClientProtocol.Ipad,
                Version = new Version()
                {
                    Incremental = Utils.GetBytes("5891938"),
                    Release = Utils.GetBytes("10"),
                    CodeName = Utils.GetBytes("REL"),
                    Sdk = 29,
                }
            };
        }
    }
}
