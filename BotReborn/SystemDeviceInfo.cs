using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotReborn.Model;

namespace BotReborn
{
    class SystemDeviceInfo
    {
        public static byte[] Display { get; } = Utils.GetBytes("BotReborn.114514.810");
        public static byte[] Product { get; } = Utils.GetBytes("BotReborn");
        public static byte[] Device { get; } = Utils.GetBytes("BotReborn");
        public static byte[] Board { get; } = Utils.GetBytes("BotReborn");
        public static byte[] Brand { get; } = Utils.GetBytes("BotReborn");
        public static byte[] Model { get; } = Utils.GetBytes("BotReborn");
        public static byte[] Bootloader { get; } = Utils.GetBytes("unknown");

        public static byte[] FingerPrint { get; } = Utils.GetBytes("BotReborn:10/BotReborn.114514.810/114514:user/release-keys");

        public static byte[] BootId { get; } = Utils.GetBytes("cb886ae2-00b6-4d68-a230-787f111d12c7");

        public static byte[] ProcVersion { get; } = Utils.GetBytes("Linux version 3.0.31-cb886ae2 (android-build@xxx.xxx.xxx.xxx.com)");

        public static byte[] BaseBand { get; } = System.Array.Empty<byte>();
        public static byte[] SimInfo { get; } = Utils.GetBytes("T-Mobile");
        public static byte[] OSType { get; } = Utils.GetBytes("android");
        public static byte[] MacAddress { get; } = Utils.GetBytes("00:50:56:C0:00:08");
        public static byte[] IpAddress { get; } = new byte[] { 10, 0, 1, 3 }; // 10.0.1.3
        public static byte[] WifiBSSID { get; } = Utils.GetBytes("00:50:56:C0:00:08");
        public static byte[] WifiSSID { get; } = Utils.GetBytes("<unknown ssid>");
        public static string IMEI { get; } = "468356291846738";
        public static byte[] AndroidId { get; } = Utils.GetBytes("MIRAI.123456.001");
        public static byte[] APN { get; } = Utils.GetBytes("wifi");
        public static byte[] VendorName { get; } = Utils.GetBytes("MIUI");
        public static byte[] VendorOSName { get; } = Utils.GetBytes("mirai");
        public static ClientProtocol Protocol { get; } = ClientProtocol.IPad;

        public static Version Version { get; } = new Version()
        {
            Incremental = Utils.GetBytes("5891938"),
            Release = Utils.GetBytes("10"),
            CodeName = Utils.GetBytes("REL"),
            Sdk = 29,
        };
    }
}
