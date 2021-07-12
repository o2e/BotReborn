using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn
{
    public class LogInSigInfo
    {
        public long LoginBitmap { get; set; }
        public byte[] Tgt { get; set; }
        public byte[] TgtKey { get; set; }
        public byte[] SrmToken { get; set; }
        public byte[] T133 { get; set; }
        public byte[] EncryptedA1 { get; set; }
        public byte[] UserStKey { get; set; }
        public byte[] UserStWebSig { get; set; }
        public byte[] SKey { get; set; }
        public long SKeyExpiredTime { get; set; }
        public byte[] D2 { get; set; }
        public byte[] D2Key { get; set; }
        public byte[] WtSessionTicketKey { get; set; }
        public byte[] DeviceToken { get; set; }

        public Dictionary<string, byte[]> PsKeyMap { get; set; }
        public Dictionary<string, byte[]> Pt4TokenMap { get; set; }
    }
}
