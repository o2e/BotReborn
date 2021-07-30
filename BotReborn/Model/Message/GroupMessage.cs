namespace BotReborn.Model.Message
{
    public class GroupMessage
    {
        public int Id { get; }
        public int InternralId { get; }
        public long GroupCode { get; }
        public string GroupName { get; }
        public Sender Sender { get; }
        public int Time { get; }
        public IMessageElement[] Elements { get; }
        //OriginalObject *msg.Message
    }
}
