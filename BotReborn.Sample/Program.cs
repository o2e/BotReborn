using System;
using System.Net;
using System.Net.Sockets;

using Microsoft.Extensions.Logging;

using Serilog;
using Serilog.Events;

namespace BotReborn.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var uin = long.Parse((Environment.GetEnvironmentVariable("BotAccount", EnvironmentVariableTarget.User) ?? Environment.GetEnvironmentVariable("BotAccount"))!);
            var passwd = Environment.GetEnvironmentVariable("BotPassword", EnvironmentVariableTarget.User) ?? Environment.GetEnvironmentVariable("BotPassword");
            var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .WriteTo.Console(LogEventLevel.Debug)
                .CreateLogger();
            var client = new OicqClient(uin, passwd)
            {
                AllowSlider = true,
                Protocol = ClientProtocol.AndroidPhone,
                Logger = LoggerFactory.Create(builder =>
                {
                    builder.AddSerilog(logger);
                }).CreateLogger<OicqClient>()
            };
            //Extension.DebugInput();
            client.Login();
        }
    }
}
