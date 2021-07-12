namespace BotReborn.Model {
    public class Sender {
        public long Uin;
        public string NickName;
        public string CardName;
        public AnonymousInfo AnonymousInfo;
        public bool IsFriend;
    }

    public struct AnonymousInfo {
        public string AnonymousId;
        public string AnonymousNick;
    }
}