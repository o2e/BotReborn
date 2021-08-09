using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn.Events
{
    public class LoginEventArgs:EventArgs
    {
        public LoginResponse Response { get; set; }
    }
}
