namespace BotReborn.Model.Group {
    public class GroupInfo {
        public long Uin { get; set; }
        public long Code { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public long OwnerUin { get; set; }
        public uint GroupCreateTime { get; set; }
        public uint GroupLevel { get; set; }
        public ushort MemberCount { get; set; }
        public ushort MaxMemberCount { get; set; }
        public GroupMemberInfo[] Members { get; set; }
        /// <summary>
        /// 最后一条信息的SEQ,只有通过 GetGroupInfo 函数获取的 GroupInfo 才会有
        /// </summary>
        public long LastMsgSeq { get; set; }
        public Client Client { get; set; }
        //TODO lock sync.RWMutex
    }
}