using System;
using BotReborn.Protos;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace BotReborn.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var uin = long.Parse((Environment.GetEnvironmentVariable("BotAccount", EnvironmentVariableTarget.User) ?? Environment.GetEnvironmentVariable("BotAccount"))!);
            var passwd = Environment.GetEnvironmentVariable("BotPassword", EnvironmentVariableTarget.User) ?? Environment.GetEnvironmentVariable("BotPassword");
            var client = new OicqClient(uin, passwd)
            {
                AllowSlider = true,
                Logger = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                    builder.SetMinimumLevel(LogLevel.Debug);
                }).CreateLogger<OicqClient>()
            };
            client.Login();
        }
    }
}
