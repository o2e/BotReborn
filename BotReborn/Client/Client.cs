using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BotReborn.Tests")]
namespace BotReborn.Client
{
    public class Client
    {
        public Uin Uin { get; set; }
        public byte[] PasswordMd5 { get; set; }
        public bool AllowSlider { get; set; }
        public string NickName { get; set; }
        public ushort Age { get; set; }
        public ushort Gender { get; set; }
        public List<Friend> Friends { get; set; }
        public List<Group> Groups { get; set; }
        public List<Device> Devices { get; set; }
        public bool IsOnline { get; set; }

        private Client()
        {
            
        }

        public Client(Uin uin,string password)
        {
            
        }

        public Client(Uin uin, byte[] passwordMd5)
        {

        }

        public Client(Uin uin, Span<byte> passwordMd5)
        {
            //TODO FetchPubKey
            var client = new Client
            {
                Uin = uin,
                PasswordMd5 = passwordMd5.ToArray()
            };

        }
    }
}
