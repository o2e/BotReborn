namespace BotReborn.Model.Message {
    public class PrivateMessage {
        public int Id { get; set; }
        public int InternalId { get; set; }
        public long Self { get; set; }
        public long Target { get; set; }
        public int Time { get; set; }
        public Sender Sender { get; set; }
        public IMessageElement Elements { get; set; }
    }
}