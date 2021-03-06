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
    public partial class OicqClient
    {
        private OicqClient(Uin uin)
        {
            _ecdh = new Ecdh();
            _httpClient = new HttpClient
            {
                DefaultRequestVersion = new Version(2, 0),
                DefaultRequestHeaders = { }
            };
            Uin = uin;
            _random = new Random();//DateTime.Now.Second
            _groupSeq = _random.Next(20000);
            Ksid = Encoding.UTF8.GetBytes($"|{DeviceInfo.IMEI}|A8.2.7.27f6ea96");
            _sequenceId = 0x3635;
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
            RandomKey = new byte[16];
            _random.NextBytes(RandomKey);
        }

        public OicqClient(Uin uin, string password) : this(uin)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            PasswordMd5 = MD5.HashData(bytes);
        }

        public OicqClient(Uin uin, byte[] passwordMd5) : this(uin)
        {
            PasswordMd5 = passwordMd5;
        }
    }
}
