namespace BotReborn.Model.Message.Element
{
    public class TextElement : IMessageElement
    {
        public string Content { get; set; }
        public ElementType Type() => ElementType.Text;

        public TextElement(string content) => Content = content;
    }
}
