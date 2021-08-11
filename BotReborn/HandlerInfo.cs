using System;
using System.Collections.Generic;

namespace BotReborn
{
    class HandlerInfo
    {
        public Action<object> Func;
        public Dictionary<string, object> Params;
    }
}
