using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using BotReborn.Crypto;

[assembly:InternalsVisibleTo("BotReborn.Tests")]
namespace BotReborn
{
    public partial class Client
    {
        private Client(Uin uin, ILogger logger)
        {
            _logger = logger;
            _ecdh = new EncryptECDH();
            _httpClient = new HttpClient();
            _random = new Random(DateTime.Now.Second);
            _md5 = MD5.Create();

            Uin = uin;
            AllowSlider = true;
            RandomKey = new byte[16];
            OutGoingPacketSessionId = new byte[] { 0x02, 0xB0, 0x5B, 0x8B }; //Magic number
            //TCP: &utils.TCPListener{ },
            SigInfo = new LogInSigInfo();
            _requestPacketRequestId = 1921334513; //Magic number
            _groupSeq = _random.Next(20000);
            _friendSeq = 22911; //Magic number
            _highwayApplyUpSeq = 77918; //Magic number
            Ksid = Utils.GetBytes($"|{DeviceInfo.Default.IMEI}|A8.2.7.27f6ea96");
            //eventHandlers:           &eventHandlers{},
            //msgSvcCache: utils.NewCache(time.Second * 15),
            //transCache: utils.NewCache(time.Second * 15),
            //onlinePushCache: utils.NewCache(time.Second * 15),
            //version:                 genVersionInfo(DefaultDeviceInfo.Protocol),
            Servers = new List<IPEndPoint>();
            //sso, err:= getSSOAddress()
            //if err == nil && len(sso) > 0 {
            //    cli.servers = append(sso, cli.servers...)

            //}
            var addresses = Dns.GetHostAddresses("msfwifi.3g.qq.com");
            if (addresses.Length > 0)
            {
                Servers.AddRange(addresses.Select(_ => new IPEndPoint(_, 8080)));
            }
        }

        public Client(Uin uin, ILogger logger, string password) : this(uin, logger)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            PasswordMd5 = _md5.ComputeHash(bytes);
        }

        public Client(Uin uin, ILogger logger, byte[] passwordMd5) : this(uin, logger)
        {
            PasswordMd5 = passwordMd5;
        }
    }
}
