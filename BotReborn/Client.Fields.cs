using System;
using System.Security.Cryptography;
using Microsoft.Extensions.Logging;

namespace BotReborn
{
    public partial class Client
    {
        private EncryptECDH _ecdh;
        private Random _random;
        private MD5 _md5;
        private ILogger _logger;
        private int _sequenceId;
        private int _requestPacketRequestId;
        private int _groupSeq;
        private int _friendSeq;
        private bool _heartbeatEnabled;
        private int _groupDataTransSeq;
        private int _highwayApplyUpSeq;
    }
}
