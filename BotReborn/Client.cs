using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BotReborn
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
            //TODO FetchPubKey

        }
    }
}
