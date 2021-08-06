using System;
using System.Collections.Generic;

namespace BotReborn
{
    public struct HandlerInfo
    {
        public Action<object, Exception> Func { get; set; }
        public Dictionary<string, object> Param { get; set; }
    }

    public struct ChannelData
    {
        public object Response { get; set; }
        public Exception Err { get; set; }
    }
}
