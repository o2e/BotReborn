namespace BotReborn.Model.Group {
    public class GroupMemberInfo {
        public GroupInfo GroupInfo { get; set; }
        public long Uin { get; set; }
        public byte Gender { get; set; }
        public string Nickname { get; set; }
        public string CardName { get; set; }
        public ushort Level { get; set; }
        public long JoinTime { get; set; }
        public long LastSpeakTime { get; set; }
        public string SpecialTitle { get; set; }
        public long SpecialTitleExpireTime { get; set; }
        public MemberPermission Permission { get; set; }
    }
}