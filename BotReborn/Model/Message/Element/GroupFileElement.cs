using System;

namespace BotReborn.Model.Message.Element
{
    public class GroupFileElement : IMessageElement
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public int BusId { get; set; }
        public ElementType Type() => ElementType.File;
    }
}
