namespace BotReborn.Model.Message.Element
{
    public class RedBagElement : IMessageElement
    {
        public RedBagMessageType MessageType { get; set; }
        public string Title { get; set; }
        public ElementType Type() => ElementType.RedBag;
    }

    public enum RedBagMessageType
    {
        RedBagSimple = 2,
        RedBagLucky = 3,
        RedBagSimpleTheme = 4,
        RedBagLuckyTheme = 5,
        RedBagWord = 6,
        RedBagSimpleSpecify = 7,
        RedBagLuckySpecify = 8,
        RedBagSimpleSpecifyOver3 = 11,
        RedBagLuckySpecifyOver3 = 12,
        RedBagVoice = 13,
        RedBagLook = 14, // ?
        RedBagVoiceC2C = 15,
        RedBagH5 = 17,
        RedBagKSong = 18,
        RedBagEmoji = 19,
        RedBagDraw = 22,
        RedBagH5Common = 20,
        RedBagWordChain = 24,
        RedBagKeyword = 25, // ?
        RedBagDrawMultiModel = 26 // ??
    }
}
