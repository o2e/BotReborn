using System;
using System.Net.Http;
using System.Security.Cryptography;
using BotReborn.Crypto;
using Microsoft.Extensions.Logging;

namespace BotReborn
{
    public partial class OicqClient
    {
        private EncryptEcdh _ecdh;
        private Random _random;
        private MD5 _md5;
        private HttpClient _httpClient;
        private int _sequenceId;
        private int _requestPacketRequestId;
        private int _groupSeq;
        private int _friendSeq;
        private bool _heartbeatEnabled;
        private int _groupDataTransSeq;
        private int _highwayApplyUpSeq;
    }
}
