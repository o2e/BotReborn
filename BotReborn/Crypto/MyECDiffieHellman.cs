using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Node;
using System.Threading.Tasks;

namespace BotReborn
{
    public class MyECDiffieHellman : ECDiffieHellman
    {

        public override ECDiffieHellmanPublicKey PublicKey => throw new NotImplementedException();
    }
}
