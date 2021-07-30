namespace BotReborn.Model.Message.Element
{
    public class LightAppElement : IMessageElement
    {
        public string Content { get; set; }
        public ElementType Type() => ElementType.LightApp;
        public LightAppElement(string content) => Content = content;
    }
}
