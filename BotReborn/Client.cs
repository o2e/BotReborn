using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BotReborn.Crypto;

[assembly: InternalsVisibleTo("BotReborn.Tests")]
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
            var sso = GetSSOAddresses();
            if (sso.Count > 0)
            {
                Servers.AddRange(sso);
            }
            var addresses = Dns.GetHostAddresses("msfwifi.3g.qq.com");
            if (addresses.Length > 0)
            {
                Servers.AddRange(addresses.Select(_ => new IPEndPoint(_, 8080)));
            }

            if (Servers.Count == 0)
            {
                Servers = new List<IPEndPoint>()
                {
                    new(IPAddress.Parse("42.81.172.81"),80),
                    new(IPAddress.Parse("114.221.148.59"),14000),
                    new(IPAddress.Parse("42.81.172.147"),443),
                    new(IPAddress.Parse("125.94.60.146"),80),
                    new(IPAddress.Parse("114.221.144.215"),80),
                    new(IPAddress.Parse("42.81.172.22"),80)
                };
            }

            var pingTasks = Servers.Select(async _ =>
            {
                var ping = new Ping();
                var options = new PingOptions { DontFragment = true };
                byte[] buffer = new byte[32];
                _random.NextBytes(buffer);
                int timeout = 5 * 1000;
                var reply = await ping.SendPingAsync(_.Address, timeout, buffer, options);
                return (ipEndPoint: _, reply.RoundtripTime);
            });
            var ping = Task.WhenAll(pingTasks).Result.OrderBy(_ => _.RoundtripTime).ToList();
            if (Servers.Count > 3)
            {
                Servers = Servers.Take(Servers.Count / 2).ToList();
            }
            //cli.TCP.PlannedDisconnect(cli.plannedDisconnect)
            //cli.TCP.UnexpectedDisconnect(cli.unexpectedDisconnect)
            _random.NextBytes(RandomKey);

            throw new NotImplementedException();
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
