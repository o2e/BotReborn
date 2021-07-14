

using ProtoBuf;

/**
 * v8.5.5
 */
[ProtoContract] class CustomFaceExtPb  {
    [ProtoContract] class AnimationImageShow{[ProtoMember(1)] public     int32EffectId  {get;set;} int = 0;
        [ProtoMember(2)] public     animationParam  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ResvAttr{[ProtoMember(1)] public     imageBizType  {get;set;} int = 0;
        [ProtoMember(2)] public     customfaceType  {get;set;} int = 0;
        [ProtoMember(3)] public     emojiPackageid  {get;set;} int = 0;
        [ProtoMember(4)] public     emojiId  {get;set;} int = 0;
        [ProtoMember(5)] public     text  {get;set;} string = "";
        [ProtoMember(6)] public     doutuSuppliers  {get;set;} string = "";
        [ProtoMember(7)] public     msgImageShow  {get;set;} AnimationImageShow? = null;
        [ProtoMember(9)] public     textSummary  {get;set;} byte[] = Array.Empty<byte>();
        [ProtoMember(10)] public     emojiFrom  {get;set;} int = 0;
        [ProtoMember(11)] public     emojiSource  {get;set;} string = "";
        [ProtoMember(12)] public     emojiWebUrl  {get;set;} string = "";
        [ProtoMember(13)] public     emojiIconUrl  {get;set;} string = "";
        [ProtoMember(14)] public     emojiMarketFaceName  {get;set;} string = "";
        [ProtoMember(15)] public     source  {get;set;} int = 0;
        [ProtoMember(16)] public     cameraCaptureTemplateinfo  {get;set;} string = "";
        [ProtoMember(17)] public     cameraCaptureMaterialname  {get;set;} string = "";
        [ProtoMember(18)] public     adEmoJumpUrl  {get;set;} string = "";
        [ProtoMember(19)] public     adEmoDescStr  {get;set;} string = "";
    }
}
