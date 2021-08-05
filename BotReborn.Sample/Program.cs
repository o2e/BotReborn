using System;

namespace BotReborn.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var uin = int.Parse((Environment.GetEnvironmentVariable("BotAccount", EnvironmentVariableTarget.User) ?? Environment.GetEnvironmentVariable("BotAccount"))!);
            var passwd = Environment.GetEnvironmentVariable("BotPassword", EnvironmentVariableTarget.User) ?? Environment.GetEnvironmentVariable("BotPassword");
            var client = new OicqClient(uin, passwd);
            client.Login();
        }
    }
}
