using System.Collections.Generic;

namespace BotReborn.Jce
{
    public interface IJceStruct
    {

    }
    public class JceStructs : IJceStruct
    {
        public struct RequestPacket
        {
            [JceId(1)] public short IVersion;
            [JceId(2)] public byte CPacketType;
            [JceId(3)] public int IMessageType;
            [JceId(4)] public int IRequestId;
            [JceId(5)] public string SServantName;
            [JceId(6)] public string SFuncName;
            [JceId(7)] public byte[] SBuffer;
            [JceId(8)] public int ITimeout;
            [JceId(9)] public Dictionary<string, string> Context;
            [JceId(10)] public Dictionary<string, string> Status;
        }

        public struct RequestDataVersion3 : IJceStruct
        {
            [JceId(0)] public Dictionary<string, byte[]> Map;
        }

        public struct RequestDataVersion2 : IJceStruct
        {
            [JceId(0)] public Dictionary<string, Dictionary<string, byte[]>> Map;
        }

        public struct SsoServerInfo
        {
            [JceId(1)] public string Server;
            [JceId(2)] public int Port;
            [JceId(8)] public string Location;
        }

        public struct FileStoragePushFSSvcList
        {
            //todo
        }

        public struct FileStorageServerInfo
        {
            //todo
        }

        public struct BigDataChannel
        {
            //todo
        }

        public struct BigDataIPList
        {
            //todo
        }

        public struct BigDataIPInfo
        {
            //todo
        }

        public struct SvcReqRegister
        {
            //todo
        }

        public struct SvcRespRegister
        {
            //todo
        }

        public struct SvcReqRegisterNew
        {
            //todo
        }

        public struct SvcReqGetMsgV2
        {
            //todo
        }

        public struct SvcReqPullGroupMsgSeq
        {
            //todo
        }

        public struct PullGroupSeqParam
        {
            //todo
        }

        public struct SvcRespParam
        {
            //todo
        }

        public struct RequestPushNotify
        {
            //todo
        }

        public struct OnlineInfo
        {
            //todo
        }

        public struct SvcReqMSFLoginNotify
        {
            //todo
        }
    }
}
