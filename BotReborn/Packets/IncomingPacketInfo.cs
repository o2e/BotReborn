using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn.Packets
{
    class IncomingPacketInfo
    {
        public string CommandName;
        public ushort SequenceId;
        public Dictionary<string, object> Params;
    }
}
