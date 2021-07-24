using System.IO;

namespace BotReborn.Jce
{
    public class JceReader
    {
        private readonly MemoryStream _data;

        public ushort ReadUint16()
        {
            var i = _data.ReadByte();
            var b = _data.ReadByte();
            return (ushort)((i << 8) + b);
        }
    }
}
