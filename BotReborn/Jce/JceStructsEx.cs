using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn.Jce
{
    public static class JceStructsEx
    {
        public static byte[] GetBytes(this IJceStruct s)
        {
            var writer = new JceWriter();
            writer.WriteJceStructRaw(s);
            return writer.GetBytes();
        }
    }
}
