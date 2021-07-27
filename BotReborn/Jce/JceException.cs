using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn.Jce
{
    class JceException:Exception
    {
        public JceException()
        {
        }

        public JceException(string message) : base(message)
        {
        }
    }
}
