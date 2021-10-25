using System.Collections.Generic;

namespace BotReborn.Packets
{
    class IncomingPacketInfo
    {
        public string CommandName;
        public ushort SequenceId;
        public Dictionary<string, object> Params;
    }
}
