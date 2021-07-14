

using ProtoBuf;

[ProtoContract] class Oidb0x769  {
    [ProtoContract] class Camera{[ProtoMember(1)] public     primary  {get;set;} long = 0L;
        [ProtoMember(2)] public     secondary  {get;set;} long = 0L;
        [ProtoMember(3)] public     flash  {get;set;} bool = false;
    }

    [ProtoContract] class Config{[ProtoMember(1)] public     type  {get;set;} int = 0;
        [ProtoMember(2)] public     version  {get;set;} int = 0;
        [ProtoMember(3)] public     contentList  {get;set;} List<String> = new();
        [ProtoMember(4)] public     debugMsg  {get;set;} string = "";
        [ProtoMember(5)] public     msgContentList  {get;set;} List<Content> = new();
    }

    [ProtoContract] class ConfigSeq{[ProtoMember(1)] public     type  {get;set;} int = 0;
        [ProtoMember(2)] public     version  {get;set;} int = 0;
    }

    [ProtoContract] class Content{[ProtoMember(1)] public     taskId  {get;set;} int = 0;
        [ProtoMember(2)] public     compress  {get;set;} int = 0;
        [ProtoMember(10)] public     content  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class CPU{[ProtoMember(1)] public     model  {get;set;} string = "";
        [ProtoMember(2)] public     cores  {get;set;} int = 0;
        [ProtoMember(3)] public     frequency  {get;set;} int = 0;
    }

    [ProtoContract] class DeviceInfo{[ProtoMember(1)] public     brand  {get;set;} string = "";
        [ProtoMember(2)] public     model  {get;set;} string = "";
        [ProtoMember(3)] public     os  {get;set;} OS? = null;
        [ProtoMember(4)] public     cpu  {get;set;} CPU? = null;
        [ProtoMember(5)] public     memory  {get;set;} Memory? = null;
        [ProtoMember(6)] public     storage  {get;set;} Storage? = null;
        [ProtoMember(7)] public     screen  {get;set;} Screen? = null;
        [ProtoMember(8)] public     camera  {get;set;} Camera? = null;
    }

    [ProtoContract] class Memory{[ProtoMember(1)] public     total  {get;set;} long = 0L;
        [ProtoMember(2)] public     process  {get;set;} long = 0L;
    }

    [ProtoContract] class OS(
        //1 IOS | 2 ANDROID | 3 OTHER
        [ProtoMember(1)] public     type  {get;set;} int /* enum */ = 1;
        [ProtoMember(2)] public     version  {get;set;} string = "";
        [ProtoMember(3)] public     sdk  {get;set;} string = "";
        [ProtoMember(4)] public     kernel  {get;set;} string = "";
        [ProtoMember(5)] public     rom  {get;set;} string = "";
    }

    [ProtoContract] class QueryUinPackageUsageReq{[ProtoMember(1)] public     type  {get;set;} int = 0;
        [ProtoMember(2)] public     uinFileSize  {get;set;} long = 0L;
    }

    [ProtoContract] class QueryUinPackageUsageRsp{[ProtoMember(1)] public     status  {get;set;} int = 0;
        [ProtoMember(2)] public     leftUinNum  {get;set;} long = 0L;
        [ProtoMember(3)] public     maxUinNum  {get;set;} long = 0L;
        [ProtoMember(4)] public     proportion  {get;set;} int = 0;
        [ProtoMember(10)] public     uinPackageUsedList  {get;set;} List<UinPackageUsedInfo> = new();
    }

    [ProtoContract] class ReqBody{[ProtoMember(1)] public     configList  {get;set;} List<ConfigSeq> = new();
        [ProtoMember(2)] public     msgDeviceInfo  {get;set;} DeviceInfo? = null;
        [ProtoMember(3)] public     info  {get;set;} string = "";
        [ProtoMember(4)] public     province  {get;set;} string = "";
        [ProtoMember(5)] public     city  {get;set;} string = "";
        [ProtoMember(6)] public     reqDebugMsg  {get;set;} int = 0;
        [ProtoMember(101)] public     queryUinPackageUsageReq  {get;set;} QueryUinPackageUsageReq? = null;
    }

    [ProtoContract] class RspBody{[ProtoMember(1)] public     result  {get;set;} int = 0;
        [ProtoMember(2)] public     configList  {get;set;} List<Config> = new();
        [ProtoMember(101)] public     queryUinPackageUsageRsp  {get;set;} QueryUinPackageUsageRsp? = null;
    }

    [ProtoContract] class Screen{[ProtoMember(1)] public     model  {get;set;} string = "";
        [ProtoMember(2)] public     width  {get;set;} int = 0;
        [ProtoMember(3)] public     height  {get;set;} int = 0;
        [ProtoMember(4)] public     dpi  {get;set;} int = 0;
        [ProtoMember(5)] public     multiTouch  {get;set;} bool = false;
    }

    [ProtoContract] class Storage{[ProtoMember(1)] public     builtin  {get;set;} long = 0L;
        [ProtoMember(2)] public     external  {get;set;} long = 0L;
    }

    [ProtoContract] class UinPackageUsedInfo{[ProtoMember(1)] public     ruleId  {get;set;} int = 0;
        [ProtoMember(2)] public     author  {get;set;} string = "";
        [ProtoMember(3)] public     url  {get;set;} string = "";
        [ProtoMember(4)] public     uinNum  {get;set;} long = 0L;
    }
}
