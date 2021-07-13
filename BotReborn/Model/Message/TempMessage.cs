namespace BotReborn.Model.Message
{
    public class TempMessage
    {
        public int Id { get; }
        public long GroupCode { get; }
        public string GroupName { get; }
        public long Self { get; set; }
        public IMessageElement Elements { get; set; }
    }
}