using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn.Jce
{
    [AttributeUsage(AttributeTargets.Field)]
    public class JceIdAttribute:Attribute
    {
        public int Id { get; set; }

        public JceIdAttribute(int id) => Id = id;
    }
}
