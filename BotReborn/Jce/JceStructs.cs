namespace BotReborn.Jce
{
    public interface IJceStruct
    {

    }
    public class JceStructs:IJceStruct
    {
        public struct RequestPacket
        {
            public short IVersion;
            public byte CPacketType;
            public int IMessageType;
            public int IRequestId;
            public string SServantName;
            public string SFuncName;
            public byte[] SBuffer;
            public int ITimeout;
            public Dictionary<string, string> Context;
            public Dictionary<string, string> Status;
        }
        public struct RequestDataVersion3:IJceStruct
        {
            public Dictionary<string, byte[]> Map;
        }
        public struct RequestDataVersion2:IJceStruct
        {
            public Dictionary<string, Dictionary<string, byte[]>> Map;
        }
    }
}
