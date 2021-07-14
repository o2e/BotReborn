







using ProtoBuf;

import net.mamoe.mirai.internal.network.protocol.packet.chat.CheckableStruct


internal class Oidb0x6d7  {
    [ProtoContract] class CreateFolderReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     parentFolderId  {get;set;} string = "";
        [ProtoMember(4)] public     folderName  {get;set;} string = "";
    }

    [ProtoContract] class CreateFolderRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     folderInfo  {get;set;} GroupFileCommon.FolderInfo? = null;
    }; CheckableStruct

    [ProtoContract] class DeleteFolderReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     folderId  {get;set;} string = "";
    }

    [ProtoContract] class DeleteFolderRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
    }; CheckableStruct

    [ProtoContract] class MoveFolderReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     folderId  {get;set;} string = "";
        [ProtoMember(4)] public     parentFolderId  {get;set;} string = "";
        [ProtoMember(5)] public     destFolderId  {get;set;} string = "";
    }

    [ProtoContract] class MoveFolderRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     folderInfo  {get;set;} GroupFileCommon.FolderInfo? = null;
    }; CheckableStruct

    [ProtoContract] class RenameFolderReqBody{[ProtoMember(1)] public     groupCode  {get;set;} long = 0L;
        [ProtoMember(2)] public     appId  {get;set;} int = 0;
        [ProtoMember(3)] public     folderId  {get;set;} string = "";
        [ProtoMember(4)] public     newFolderName  {get;set;} string = "";
    }

    [ProtoContract] class RenameFolderRspBody(
       [ProtoMember(1) override val int32RetCode  {get;set;} int = 0;
       [ProtoMember(2) override val retMsg  {get;set;} string = "";
        [ProtoMember(3)] public     clientWording  {get;set;} string = "";
        [ProtoMember(4)] public     folderInfo  {get;set;} GroupFileCommon.FolderInfo? = null;
    }; CheckableStruct

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     createFolderReq  {get;set;} CreateFolderReqBody? = null;
        [ProtoMember(2)] public     deleteFolderReq  {get;set;} DeleteFolderReqBody? = null;
        [ProtoMember(3)] public     renameFolderReq  {get;set;} RenameFolderReqBody? = null;
        [ProtoMember(4)] public     moveFolderReq  {get;set;} MoveFolderReqBody? = null;
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     createFolderRsp  {get;set;} CreateFolderRspBody? = null;
        [ProtoMember(2)] public     deleteFolderRsp  {get;set;} DeleteFolderRspBody? = null;
        [ProtoMember(3)] public     renameFolderRsp  {get;set;} RenameFolderRspBody? = null;
        [ProtoMember(4)] public     moveFolderRsp  {get;set;} MoveFolderRspBody? = null;
    }
}
