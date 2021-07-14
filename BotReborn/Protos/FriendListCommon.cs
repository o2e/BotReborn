

using ProtoBuf;

@file  {get;set;}Suppress("SpellCheckingInspection")[ProtoContract] class Vec0xd50  {
    [ProtoContract] class ExtSnsFrdData(
       [ProtoMember(1)] public   frdUin  {get;set;} long = 0L;
       [ProtoMember(91001)] public   musicSwitch  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(101001)] public   mutualmarkAlienation  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(141001)] public   mutualmarkScore  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(151001)] public   ksingSwitch  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(181001)] public   lbsShare  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class RspBody(
       [ProtoMember(1)] public   msgUpdateData  {get;set;} List<ExtSnsFrdData> = new();
       [ProtoMember(11)] public   over  {get;set;} int = 0;
       [ProtoMember(12)] public   nextStart  {get;set;} int = 0;
       [ProtoMember(13)] public   uint64UnfinishedUins  {get;set;} List<Long> = new()
    }

    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   appid  {get;set;} long = 0L;
       [ProtoMember(2)] public   maxPkgSize  {get;set;} int = 0;
       [ProtoMember(3)] public   startTime  {get;set;} int = 0;
       [ProtoMember(4)] public   startIndex  {get;set;} int = 0;
       [ProtoMember(5)] public   reqNum  {get;set;} int = 0;
       [ProtoMember(6)] public   uinList  {get;set;} List<Long> = new();
       [ProtoMember(91001)] public   reqMusicSwitch  {get;set;} int = 0;
       [ProtoMember(101001)] public   reqMutualmarkAlienation  {get;set;} int = 0;
       [ProtoMember(141001)] public   reqMutualmarkScore  {get;set;} int = 0;
       [ProtoMember(151001)] public   reqKsingSwitch  {get;set;} int = 0;
       [ProtoMember(181001)] public   reqMutualmarkLbsshare  {get;set;} int = 0
    }

    [ProtoContract] class KSingRelationInfo(
       [ProtoMember(1)] public   flag  {get;set;} int = 0
    }
}

[ProtoContract] class Vec0xd6b  {
    [ProtoContract] class ReqBody(
       [ProtoMember(1)] public   maxPkgSize  {get;set;} int = 0;
       [ProtoMember(2)] public   startTime  {get;set;} int = 0;
       [ProtoMember(11)] public   uinList  {get;set;} List<Long> = new()
    }

    [ProtoContract] class RspBody(
       [ProtoMember(11)] public   msgMutualmarkData  {get;set;} List<MutualMarkData> = new();
       [ProtoMember(12)] public   uint64UnfinishedUins  {get;set;} List<Long> = new()
    }

    [ProtoContract] class MutualMarkData(
       [ProtoMember(1)] public   frdUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   result  {get;set;} int = 0
        // @SerialId(11)] public   mutualmarkInfo  {get;set;} List<Mutualmark.MutualMark> = new()
    }
}
