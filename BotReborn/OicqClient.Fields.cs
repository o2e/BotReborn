using System;
using System.Collections.Concurrent;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Channels;
using BotReborn.Crypto;

using Microsoft.Extensions.Logging;

namespace BotReborn
{
    public partial class OicqClient
    {
        private Ecdh _ecdh;
        private Random _random;
        private SemaphoreSlim _once = new(1, 1);
        private HttpClient _httpClient;
        private ConcurrentDictionary<ushort, HandlerInfo> _handlers = new();
        private Channel<object> _channel =  Channel.CreateUnbounded<object>();
        private int _sequenceId;
        private int _requestPacketRequestId = 1921334513;
        private int _groupSeq;
        private int _friendSeq = 22911;
        private bool _heartbeatEnabled;
        private int _groupDataTransSeq;
        private int _highwayApplyUpSeq = 77918;
    }
}
