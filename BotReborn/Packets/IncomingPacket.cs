namespace BotReborn.Packets
{
    public class IncomingPacket
    {
        public ushort SequenceId;
        public byte Flag2;
        public string CommandName;
        public byte[] SessionId;
        public byte[] Payload;
    }
}
