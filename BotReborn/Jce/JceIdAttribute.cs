using System;

namespace BotReborn.Jce
{
    [AttributeUsage(AttributeTargets.Field)]
    public class JceIdAttribute : Attribute
    {
        public int Id { get; set; }

        public JceIdAttribute(int id) => Id = id;
    }
}
