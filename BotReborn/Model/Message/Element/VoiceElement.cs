using BotReborn.Protos;

namespace BotReborn.Model.Message.Element
{
    public class VoiceElement : IMessageElement
    {
        public string Name { get; set; }
        public byte[] Md5 { get; set; }
        public int Size { get; set; }
        public string Url { get; set; }
        /// <summary>
        /// 在发送时使用
        /// </summary>
        public byte[] Data { get; set; }

        public ElementType Type() => ElementType.Voice;
    }

    public class GroupVoiceElement : IMessageElement
    {
        public byte[] Data { get; set; }
        public Ptt Ptt { get; set; }
        public ElementType Type() => ElementType.Voice;
    }

    public class PrivateVoiceElement : IMessageElement
    {
        public byte[] Data { get; set; }
        public Ptt Ptt { get; set; }
        public ElementType Type() => ElementType.Voice;
    }
}
