namespace BotReborn.Model.Message.Element {
    public class VoiceElement {
        public string Name { get; set; }
        public byte[] Md5 { get; set; }
        public int Size { get; set; }
        public string Url { get; set; }
        /// <summary>
        /// 在发送时使用
        /// </summary>
        public byte[] Data { get; set; }
    }
}