using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn
{
    public readonly struct Uin
    {
        private Uin(long value) => _value = value;
        private readonly long _value;
        public static implicit operator long(Uin value) => value._value;
        public static implicit operator Uin(long value) => new(value);
        public override string ToString() => _value.ToString("D10");
    }
}
