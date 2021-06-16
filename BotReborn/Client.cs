using System;
using System.Runtime.CompilerServices;

namespace BotReborn
{
    public class Client
    {
        public Client()
        {
            
        }

        public Client(UserId userId,string password)
        {
            var client = new Client();
        }

        public Client(UserId userId, byte[] passwordMd5)
        {

        }

        public Client(UserId userId, Span<byte> passwordMd5)
        {

        }
    }
}
