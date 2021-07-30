namespace BotReborn.Model.Message.Element
{
    public class AtElement : IMessageElement
    {
        /// <summary>
        /// @，target=0 为 @全体成员
        /// </summary>
        /// <param name="target"></param>
        /// <param name="display"></param>
        public AtElement(long target, string display)
        {
            if (target == 0)
            {
                Display = "@全体成员";
                Target = 0;
            }
            Target = target;
            Display = display;
        }
        public AtElement() { }

        public long Target { get; set; }
        public string Display { get; set; }
        public ElementType Type() => ElementType.At;
    }
}
