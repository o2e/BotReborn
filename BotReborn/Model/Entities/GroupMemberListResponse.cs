using BotReborn.Model.Group;

namespace BotReborn.Model.Entities
{
    public struct GroupMemberListResponse
    {
        public long NextUin { get; set; }
        public GroupMemberInfo[] List { get; set; }
    }
}
