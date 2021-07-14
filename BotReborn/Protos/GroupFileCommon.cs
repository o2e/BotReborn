

using ProtoBuf;

internal class GroupFileCommon  {
    [ProtoContract] class FeedsInfo{[ProtoMember(1)] public     busId  {get;set;} int = 0;
        [ProtoMember(2)] public     fileId  {get;set;} string = "";
        [ProtoMember(3)] public     msgRandom  {get;set;} int = 0;
        [ProtoMember(4)] public     ext  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(5)] public     feedFlag  {get;set;} int = 0;
        [ProtoMember(6)] public     msgCtrl  {get;set;} MsgCtrl.MsgCtrl? = null
    }

    [ProtoContract] class FeedsResult{[ProtoMember(1)] public     int32RetCode  {get;set;} int = 0;
        [ProtoMember(2)] public     detail  {get;set;} string = "";
        [ProtoMember(3)] public     fileId  {get;set;} string = "";
        [ProtoMember(4)] public     busId  {get;set;} int = 0;
        [ProtoMember(5)] public     deadTime  {get;set;} int = 0
    }

    [ProtoContract] class FileInfo{[ProtoMember(1)] public     fileId  {get;set;} string = "";
        [ProtoMember(2)] public     fileName  {get;set;} string = "";
        [ProtoMember(3)] public     fileSize  {get;set;} long = 0L;
        [ProtoMember(4)] public     busId  {get;set;} int = 0;
        [ProtoMember(5)] public     uploadedSize  {get;set;} long = 0L;
        [ProtoMember(6)] public     uploadTime  {get;set;} int = 0;
        [ProtoMember(7)] public     deadTime  {get;set;} int = 0;
        [ProtoMember(8)] public     modifyTime  {get;set;} int = 0;
        [ProtoMember(9)] public     downloadTimes  {get;set;} int = 0;
        [ProtoMember(10)] public     sha  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(11)] public     sha3  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(12)] public     md5  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(13)] public     localPath  {get;set;} string = "";
        [ProtoMember(14)] public     uploaderName  {get;set;} string = "";
        [ProtoMember(15)] public     uploaderUin  {get;set;} long = 0L;
        [ProtoMember(16)] public     parentFolderId  {get;set;} string = "";
        [ProtoMember(17)] public     safeType  {get;set;} int = 0;
        [ProtoMember(20)] public     fileBlobExt  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(21)] public     ownerUin  {get;set;} long = 0L;
        [ProtoMember(22)] public     feedId  {get;set;} string = "";
        [ProtoMember(23)] public     reservedField  {get;set;} byte[] = Array.Empty<byte>()
    }

    [ProtoContract] class FileInfoTmem{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     files  {get;set;} List<FileInfo> = new()
    }

    [ProtoContract] class FileItem{[ProtoMember(1)] public     type  {get;set;} int = 0;
        [ProtoMember(2)] public     folderInfo  {get;set;} FolderInfo? = null;
        [ProtoMember(3)] public     fileInfo  {get;set;} FileInfo? = null
    }

    [ProtoContract] class FolderInfo{[ProtoMember(1)] public     folderId  {get;set;} string = ""; // uuid
        [ProtoMember(2)] public     parentFolderId  {get;set;} string = "";
        [ProtoMember(3)] public     folderName  {get;set;} string = "";
        [ProtoMember(4)] public     createTime  {get;set;} int = 0;
        [ProtoMember(5)] public     modifyTime  {get;set;} int = 0;
        [ProtoMember(6)] public     createUin  {get;set;} long = 0L;
        [ProtoMember(7)] public     creatorName  {get;set;} string = "";
        [ProtoMember(8)] public     totalFileCount  {get;set;} int = 0;
        [ProtoMember(9)] public     modifyUin  {get;set;} long = 0L;
        [ProtoMember(10)] public     modifyName  {get;set;} string = "";
        [ProtoMember(11)] public     usedSpace  {get;set;} long = 0L
    }

    [ProtoContract] class FolderInfoTmem{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     folders  {get;set;} List<FolderInfo> = new()
    }

    [ProtoContract] class OverwriteInfo{[ProtoMember(1)] public     fileId  {get;set;} string = "";
        [ProtoMember(2)] public     downloadTimes  {get;set;} int = 0
    }
}
