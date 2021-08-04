using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn
{
    partial class Client
    {
        public (ushort, byte[]) BuildLoginPacket()
        {
            var seq = NextSeq();
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildDeviceLockLoginPacket()
        {
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildQrCodeFetchRequestPacket()
        {
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildQrCodeResultQueryRequestPacket()
        {
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildQrCodeLoginPacket()
        {
            throw new NotImplementedException();
        }

        public (ushort, byte[]) BuildCaptchaPacket()
        {
            throw new NotImplementedException();
        }
    }
}
