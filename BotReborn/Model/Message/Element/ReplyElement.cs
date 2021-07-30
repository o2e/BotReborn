using System.Xml.Linq;

namespace BotReborn.Model.Message.Element
{
    public class ReplyElement : IMessageElement
    {
        /// <summary>
        /// 新建群回复
        /// </summary>
        /// <param name="groupMessage"></param>
        public ReplyElement(GroupMessage groupMessage)
        {
            ReplySeq = groupMessage.Id;
            Sender = groupMessage.Sender.Uin;
            Time = groupMessage.Time;
            Elements = groupMessage.Elements;
        }

        /// <summary>
        /// 新建私人回复
        /// </summary>
        public ReplyElement(PrivateMessage privateMessage)
        {
            ReplySeq = privateMessage.Id;
            Sender = privateMessage.Sender.Uin;
            Time = privateMessage.Time;
            Elements = privateMessage.Elements;
        }

        public ReplyElement() { }

        public int ReplySeq { get; set; }
        public long Sender { get; set; }
        public int Time { get; set; } //int will overflow
        public IMessageElement[] Elements { get; set; }

        // original []*msg.Elem
        public ElementType Type() => ElementType.Reply;
    }
}
