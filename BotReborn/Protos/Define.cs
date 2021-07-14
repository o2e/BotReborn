using ProtoBuf;

internal class Common  {
    [ProtoContract] class BindInfo(
       [ProtoMember(1)] public   friUin  {get;set;} long = 0L;
       [ProtoMember(2)] public   friNick  {get;set;} string = "";
       [ProtoMember(3)] public   time  {get;set;} long = 0L;
       [ProtoMember(4)] public   bindStatus  {get;set;} int = 0;
    }

    [ProtoContract] class MedalInfo(
       [ProtoMember(1)] public   id  {get;set;} int = 0;
       [ProtoMember(2)] public   type  {get;set;} int = 0;
       [ProtoMember(4)] public   seq  {get;set;} long = 0;
       [ProtoMember(5)] public   name  {get;set;} string = "";
       [ProtoMember(6)] public   newflag  {get;set;} int = 0;
       [ProtoMember(7)] public   time  {get;set;} long = 0L;
       [ProtoMember(8)] public   msgBindFri  {get;set;} BindInfo? = null;
       [ProtoMember(11)] public   desc  {get;set;} string = "";
       [ProtoMember(31)] public   level  {get;set;} int = 0;
       [ProtoMember(36)] public   taskinfos  {get;set;} List<MedalTaskInfo> = new();
       [ProtoMember(40)] public   point  {get;set;} int = 0;
       [ProtoMember(41)] public   pointLevel2  {get;set;} int = 0;
       [ProtoMember(42)] public   pointLevel3  {get;set;} int = 0;
       [ProtoMember(43)] public   seqLevel2  {get;set;} long = 0;
       [ProtoMember(44)] public   seqLevel3  {get;set;} long = 0;
       [ProtoMember(45)] public   timeLevel2  {get;set;} long = 0L;
       [ProtoMember(46)] public   timeLevel3  {get;set;} long = 0L;
       [ProtoMember(47)] public   descLevel2  {get;set;} string = "";
       [ProtoMember(48)] public   descLevel3  {get;set;} string = "";
       [ProtoMember(49)] public   endtime  {get;set;} int = 0;
       [ProtoMember(50)] public   detailUrl  {get;set;} string = "";
       [ProtoMember(51)] public   detailUrl2  {get;set;} string = "";
       [ProtoMember(52)] public   detailUrl3  {get;set;} string = "";
       [ProtoMember(53)] public   taskDesc  {get;set;} string = "";
       [ProtoMember(54)] public   taskDesc2  {get;set;} string = "";
       [ProtoMember(55)] public   taskDesc3  {get;set;} string = "";
       [ProtoMember(56)] public   levelCount  {get;set;} int = 0;
       [ProtoMember(57)] public   noProgress  {get;set;} int = 0;
       [ProtoMember(58)] public   resource  {get;set;} string = "";
       [ProtoMember(59)] public   fromuinLevel  {get;set;} int = 0;
       [ProtoMember(60)] public   unread  {get;set;} int = 0;
       [ProtoMember(61)] public   unread2  {get;set;} int = 0;
       [ProtoMember(62)] public   unread3  {get;set;} int = 0;
    }

    [ProtoContract] class MedalTaskInfo(
       [ProtoMember(1)] public   taskid  {get;set;} int = 0;
       [ProtoMember(32)] public   int32TaskValue  {get;set;} int = 0;
       [ProtoMember(33)] public   tarValue  {get;set;} int = 0;
       [ProtoMember(34)] public   tarValueLevel2  {get;set;} int = 0;
       [ProtoMember(35)] public   tarValueLevel3  {get;set;} int = 0;
    }
}

[ProtoContract] class AppointDefine  {
    [ProtoContract] class ADFeedContent(
       [ProtoMember(1)] public   msgUserInfo  {get;set;} UserInfo? = null;
       [ProtoMember(2)] public   strPicUrl  {get;set;} List<String> = new();
       [ProtoMember(3)] public   msgText  {get;set;} RichText? = null;
       [ProtoMember(4)] public   attendInfo  {get;set;} string = "";
       [ProtoMember(5)] public   actionUrl  {get;set;} string = "";
       [ProtoMember(6)] public   publishTime  {get;set;} int = 0;
       [ProtoMember(7)] public   msgHotTopicList  {get;set;} HotTopicList? = null;
       [ProtoMember(8)] public   moreUrl  {get;set;} string = "";
       [ProtoMember(9)] public   recordDuration  {get;set;} string = "";
    }

    [ProtoContract] class RichText(
       [ProtoMember(1)] public   msgElems  {get;set;} List<Elem> = new();
    }

    [ProtoContract] class RankEvent(
       [ProtoMember(1)] public   listtype  {get;set;} int = 0;
       [ProtoMember(2)] public   notifytype  {get;set;} int = 0;
       [ProtoMember(3)] public   eventtime  {get;set;} int = 0;
       [ProtoMember(4)] public   seq  {get;set;} int = 0;
       [ProtoMember(5)] public   notifyTips  {get;set;} string = "";
    }

    [ProtoContract] class Wifi(
       [ProtoMember(1)] public   mac  {get;set;} long = 0L;
       [ProtoMember(2)] public   int32Rssi  {get;set;} int = 0;
    }

    [ProtoContract] class InterestItem(
       [ProtoMember(1)] public   tagId  {get;set;} long = 0L;
       [ProtoMember(2)] public   tagName  {get;set;} string = "";
       [ProtoMember(3)] public   tagIconUrl  {get;set;} string = "";
       [ProtoMember(4)] public   tagHref  {get;set;} string = "";
       [ProtoMember(5)] public   tagBackColor  {get;set;} string = "";
       [ProtoMember(6)] public   tagFontColor  {get;set;} string = "";
       [ProtoMember(7)] public   tagVid  {get;set;} string = "";
       [ProtoMember(8)] public   tagType  {get;set;} int = 0;
       [ProtoMember(9)] public   addTime  {get;set;} int = 0;
       [ProtoMember(10)] public   tagCategory  {get;set;} string = "";
       [ProtoMember(11)] public   tagOtherUrl  {get;set;} string = "";
       [ProtoMember(12)] public   bid  {get;set;} int = 0;
    }

    [ProtoContract] class ShopID(
       [ProtoMember(1)] public   shopid  {get;set;} string = "";
       [ProtoMember(2)] public   sp  {get;set;} int = 0;
    }

    [ProtoContract] class FeedComment(
       [ProtoMember(1)] public   commentId  {get;set;} string = "";
       [ProtoMember(2)] public   feedId  {get;set;} string = "";
       [ProtoMember(3)] public   msgPublisherInfo  {get;set;} StrangerInfo? = null;
       [ProtoMember(4)] public   time  {get;set;} int = 0;
       [ProtoMember(6)] public   msgReplyInfo  {get;set;} ReplyInfo? = null;
       [ProtoMember(7)] public   flag  {get;set;} int = 0;
       [ProtoMember(8)] public   msgContent  {get;set;} RichText? = null;
       [ProtoMember(9)] public   hot  {get;set;} int = 0;
    }

    [ProtoContract] class ADFeed(
       [ProtoMember(1)] public   taskId  {get;set;} int = 0;
       [ProtoMember(2)] public   style  {get;set;} int = 0;
       [ProtoMember(3)] public   content  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class Cell(
       [ProtoMember(1)] public   int32Mcc  {get;set;} int = -1;
       [ProtoMember(2)] public   int32Mnc  {get;set;} int = -1;
       [ProtoMember(3)] public   int32Lac  {get;set;} int = -1;
       [ProtoMember(4)] public   int32Cellid  {get;set;} int = -1;
       [ProtoMember(5)] public   int32Rssi  {get;set;} int = 0;
    }

    [ProtoContract] class RecentVistorEvent(
       [ProtoMember(1)] public   eventtype  {get;set;} int = 0;
       [ProtoMember(2)] public   eventTinyid  {get;set;} long = 0L;
       [ProtoMember(3)] public   unreadCount  {get;set;} int = 0;
    }

    [ProtoContract] class OrganizerInfo(
       [ProtoMember(1)] public   hostName  {get;set;} string = "";
       [ProtoMember(2)] public   hostUrl  {get;set;} string = "";
       [ProtoMember(3)] public   hostCover  {get;set;} string = "";
    }

    [ProtoContract] class InterestTag(
       [ProtoMember(1)] public   tagType  {get;set;} int = 0;
       [ProtoMember(2)] public   msgTagList  {get;set;} List<InterestItem> = new();
    }

    [ProtoContract] class AppointInfoEx(
       [ProtoMember(1)] public   feedsPicUrl  {get;set;} string = "";
       [ProtoMember(2)] public   feedsUrl  {get;set;} string = "";
       [ProtoMember(3)] public   detailTitle  {get;set;} string = "";
       [ProtoMember(4)] public   detailDescribe  {get;set;} string = "";
       [ProtoMember(5)] public   showPublisher  {get;set;} int = 0;
       [ProtoMember(6)] public   detailPicUrl  {get;set;} string = "";
       [ProtoMember(7)] public   detailUrl  {get;set;} string = "";
       [ProtoMember(8)] public   showAttend  {get;set;} int = 0;
    }

    [ProtoContract] class DateComment(
       [ProtoMember(1)] public   commentId  {get;set;} string = "";
       [ProtoMember(2)] public   msgAppointId  {get;set;} AppointID? = null;
       [ProtoMember(3)] public   msgPublisherInfo  {get;set;} StrangerInfo? = null;
       [ProtoMember(4)] public   time  {get;set;} int = 0;
       [ProtoMember(6)] public   msgReplyInfo  {get;set;} ReplyInfo? = null;
       [ProtoMember(7)] public   flag  {get;set;} int = 0;
       [ProtoMember(8)] public   msgContent  {get;set;} RichText? = null;
    }

    [ProtoContract] class AppointContent(
       [ProtoMember(1)] public   appointSubject  {get;set;} int = 0;
       [ProtoMember(2)] public   payType  {get;set;} int = 0;
       [ProtoMember(3)] public   appointDate  {get;set;} int = 0;
       [ProtoMember(4)] public   appointGender  {get;set;} int = 0;
       [ProtoMember(5)] public   appointIntroduce  {get;set;} string = "";
       [ProtoMember(6)] public   msgAppointAddress  {get;set;} AddressInfo? = null;
       [ProtoMember(7)] public   msgTravelInfo  {get;set;} TravelInfo? = null;
    }

    [ProtoContract] class FeedInfo(
       [ProtoMember(1)] public   feedType  {get;set;} long = 0L;
       [ProtoMember(2)] public   feedId  {get;set;} string = "";
       [ProtoMember(3)] public   msgFeedContent  {get;set;} FeedContent? = null;
       [ProtoMember(4)] public   msgTopicInfo  {get;set;} NearbyTopic? = null;
       [ProtoMember(5)] public   publishTime  {get;set;} long = 0;
       [ProtoMember(6)] public   praiseCount  {get;set;} int = 0;
       [ProtoMember(7)] public   praiseFlag  {get;set;} int = 0;
       [ProtoMember(8)] public   msgPraiseUser  {get;set;} List<StrangerInfo> = new();
       [ProtoMember(9)] public   commentCount  {get;set;} int = 0;
       [ProtoMember(10)] public   msgCommentList  {get;set;} List<FeedComment> = new();
       [ProtoMember(11)] public   commentRetAll  {get;set;} int = 0;
       [ProtoMember(12)] public   hotFlag  {get;set;} int = 0;
       [ProtoMember(13)] public   svrReserved  {get;set;} long = 0L;
       [ProtoMember(14)] public   msgHotEntry  {get;set;} HotEntry? = null;
    }

    [ProtoContract] class HotTopicList(
       [ProtoMember(1)] public   topicList  {get;set;} List<HotTopic> = new();
    }

    [ProtoContract] class FeedContent(
       [ProtoMember(1)] public   strPicUrl  {get;set;} List<String> = new();
       [ProtoMember(2)] public   msgText  {get;set;} RichText? = null;
       [ProtoMember(3)] public   hrefUrl  {get;set;} string = "";
       [ProtoMember(5)] public   groupName  {get;set;} string = "";
       [ProtoMember(6)] public   groupBulletin  {get;set;} string = "";
       [ProtoMember(7)] public   feedType  {get;set;} int = 0;
       [ProtoMember(8)] public   poiId  {get;set;} string = "";
       [ProtoMember(9)] public   poiTitle  {get;set;} string = "";
       [ProtoMember(20)] public   effectiveTime  {get;set;} int = 0;
       [ProtoMember(21)] public   expiationTime  {get;set;} int = 0;
       [ProtoMember(22)] public   msgLocale  {get;set;} LocaleInfo? = null;
       [ProtoMember(23)] public   feedsIndex  {get;set;} int = 0;
       [ProtoMember(24)] public   msgAd  {get;set;} ADFeed? = null;
       [ProtoMember(25)] public   privateData  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class TravelInfo(
       [ProtoMember(1)] public   msgDepartLocale  {get;set;} LocaleInfo? = null;
       [ProtoMember(2)] public   msgDestination  {get;set;} LocaleInfo? = null;
       [ProtoMember(3)] public   vehicle  {get;set;} int = 0;
       [ProtoMember(4)] public   partnerCount  {get;set;} int = 0;
       [ProtoMember(5)] public   placePicUrl  {get;set;} string = "";
       [ProtoMember(6)] public   placeUrl  {get;set;} string = "";
    }

    [ProtoContract] class RecentFreshFeed(
       [ProtoMember(1)] public   freshFeedInfo  {get;set;} List<FreshFeedInfo> = new();
       [ProtoMember(2)] public   uid  {get;set;} long = 0L;
    }

    [ProtoContract] class GPS(
       [ProtoMember(1)] public   int32Lat  {get;set;} int = 900000000;
       [ProtoMember(2)] public   int32Lon  {get;set;} int = 900000000;
       [ProtoMember(3)] public   int32Alt  {get;set;} int = -10000000;
       [ProtoMember(4)] public   int32Type  {get;set;} int = 0;
    }

    [ProtoContract] class AppointID(
       [ProtoMember(1)] public   requestId  {get;set;} string = "";
    }

    [ProtoContract] class LocaleInfo(
       [ProtoMember(1)] public   name  {get;set;} string = "";
       [ProtoMember(2)] public   country  {get;set;} string = "";
       [ProtoMember(3)] public   province  {get;set;} string = "";
       [ProtoMember(4)] public   city  {get;set;} string = "";
       [ProtoMember(5)] public   region  {get;set;} string = "";
       [ProtoMember(6)] public   poi  {get;set;} string = "";
       [ProtoMember(7)] public   msgGps  {get;set;} GPS? = null;
       [ProtoMember(8)] public   address  {get;set;} string = "";
    }

    [ProtoContract] class LBSInfo(
       [ProtoMember(1)] public   msgGps  {get;set;} GPS? = null;
       [ProtoMember(2)] public   msgWifis  {get;set;} List<Wifi> = new();
       [ProtoMember(3)] public   msgCells  {get;set;} List<Cell> = new();
    }

    [ProtoContract] class FeedEvent(
       [ProtoMember(1)] public   eventId  {get;set;} long = 0L;
       [ProtoMember(2)] public   time  {get;set;} int = 0;
       [ProtoMember(3)] public   eventtype  {get;set;} int = 0;
       [ProtoMember(4)] public   msgUserInfo  {get;set;} StrangerInfo? = null;
       [ProtoMember(5)] public   msgFeedInfo  {get;set;} FeedInfo? = null;
       [ProtoMember(6)] public   eventTips  {get;set;} string = "";
       [ProtoMember(7)] public   msgComment  {get;set;} FeedComment? = null;
       [ProtoMember(8)] public   cancelEventId  {get;set;} long = 0L;
    }

    [ProtoContract] class FeedsCookie(
       [ProtoMember(1)] public   strList  {get;set;} List<String> = new();
       [ProtoMember(2)] public   pose  {get;set;} int = 0;
       [ProtoMember(3)] public   cookie  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   uint64Topics  {get;set;} List<Long> = new();
    }

    [ProtoContract] class NearbyTopic(
       [ProtoMember(1)] public   topicId  {get;set;} long = 0L;
       [ProtoMember(2)] public   topic  {get;set;} string = "";
       [ProtoMember(3)] public   foreword  {get;set;} string = "";
       [ProtoMember(4)] public   createTime  {get;set;} int = 0;
       [ProtoMember(5)] public   updateTime  {get;set;} int = 0;
       [ProtoMember(6)] public   hotFlag  {get;set;} int = 0;
       [ProtoMember(7)] public   buttonStyle  {get;set;} int = 0;
       [ProtoMember(8)] public   buttonSrc  {get;set;} string = "";
       [ProtoMember(9)] public   backgroundSrc  {get;set;} string = "";
       [ProtoMember(10)] public   attendeeInfo  {get;set;} string = "";
       [ProtoMember(11)] public   index  {get;set;} int = 0;
       [ProtoMember(12)] public   publishScope  {get;set;} int = 0;
       [ProtoMember(13)] public   effectiveTime  {get;set;} int = 0;
       [ProtoMember(14)] public   expiationTime  {get;set;} int = 0;
       [ProtoMember(15)] public   pushedUsrCount  {get;set;} int = 0;
       [ProtoMember(16)] public   timerangeLeft  {get;set;} int = 0;
       [ProtoMember(17)] public   timerangeRight  {get;set;} int = 0;
       [ProtoMember(18)] public   area  {get;set;} string = "";
    }

    [ProtoContract] class NearbyEvent(
       [ProtoMember(1)] public   eventtype  {get;set;} int = 0;
       [ProtoMember(2)] public   msgRankevent  {get;set;} RankEvent? = null;
       [ProtoMember(3)] public   eventUin  {get;set;} long = 0L;
       [ProtoMember(4)] public   eventTinyid  {get;set;} long = 0L;
    }

    [ProtoContract] class Feed(
       [ProtoMember(1)] public   msgUserInfo  {get;set;} PublisherInfo? = null;
       [ProtoMember(2)] public   msgFeedInfo  {get;set;} FeedInfo? = null;
       [ProtoMember(3)] public   ownerFlag  {get;set;} int = 0;
    }

    [ProtoContract] class ActivityInfo(
       [ProtoMember(2)] public   name  {get;set;} string = "";
       [ProtoMember(3)] public   cover  {get;set;} string = "";
       [ProtoMember(4)] public   url  {get;set;} string = "";
       [ProtoMember(5)] public   startTime  {get;set;} int = 0;
       [ProtoMember(6)] public   endTime  {get;set;} int = 0;
       [ProtoMember(7)] public   locName  {get;set;} string = "";
       [ProtoMember(8)] public   enroll  {get;set;} long = 0L;
       [ProtoMember(9)] public   createUin  {get;set;} long = 0L;
       [ProtoMember(10)] public   createTime  {get;set;} int = 0;
       [ProtoMember(11)] public   organizerInfo  {get;set;} OrganizerInfo = OrganizerInfo();
       [ProtoMember(12)] public   flag  {get;set;} long? = null;
    }

    [ProtoContract] class HotEntry(
       [ProtoMember(1)] public   openFlag  {get;set;} int = 0;
       [ProtoMember(2)] public   restTime  {get;set;} int = 0;
       [ProtoMember(3)] public   foreword  {get;set;} string = "";
       [ProtoMember(4)] public   backgroundSrc  {get;set;} string = "";
    }

    [ProtoContract] class UserFeed(
       [ProtoMember(1)] public   msgUserInfo  {get;set;} PublisherInfo? = null;
       [ProtoMember(2)] public   msgFeedInfo  {get;set;} FeedInfo? = null;
       [ProtoMember(3)] public   ownerFlag  {get;set;} int = 0;
       [ProtoMember(4)] public   msgActivityInfo  {get;set;} ActivityInfo? = null;
    }

    [ProtoContract] class Elem(
       [ProtoMember(1)] public   content  {get;set;} string = "";
       [ProtoMember(2)] public   msgFaceInfo  {get;set;} Face? = null;
    }

    [ProtoContract] class HotFreshFeedList(
       [ProtoMember(1)] public   msgFeeds  {get;set;} List<HotUserFeed> = new();
       [ProtoMember(2)] public   updateTime  {get;set;} int = 0;
    }

    [ProtoContract] class RptInterestTag(
       [ProtoMember(1)] public   interestTags  {get;set;} List<InterestTag> = new();
    }

    [ProtoContract] class AddressInfo(
       [ProtoMember(1)] public   companyZone  {get;set;} string = "";
       [ProtoMember(2)] public   companyName  {get;set;} string = "";
       [ProtoMember(3)] public   companyAddr  {get;set;} string = "";
       [ProtoMember(4)] public   companyPicUrl  {get;set;} string = "";
       [ProtoMember(5)] public   companyUrl  {get;set;} string = "";
       [ProtoMember(6)] public   msgCompanyId  {get;set;} ShopID? = null;
    }

    [ProtoContract] class PublisherInfo(
       [ProtoMember(1)] public   tinyid  {get;set;} long = 0L;
       [ProtoMember(2)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   age  {get;set;} int = 0;
       [ProtoMember(4)] public   gender  {get;set;} int = 0;
       [ProtoMember(5)] public   constellation  {get;set;} string = "";
       [ProtoMember(6)] public   profession  {get;set;} int = 0;
       [ProtoMember(7)] public   distance  {get;set;} string = "";
       [ProtoMember(8)] public   marriage  {get;set;} int = 0;
       [ProtoMember(9)] public   vipinfo  {get;set;} string = "";
       [ProtoMember(10)] public   recommend  {get;set;} int = 0;
       [ProtoMember(11)] public   godflag  {get;set;} int = 0;
       [ProtoMember(12)] public   chatflag  {get;set;} int = 0;
       [ProtoMember(13)] public   chatupCount  {get;set;} int = 0;
       [ProtoMember(14)] public   charm  {get;set;} int = 0;
       [ProtoMember(15)] public   charmLevel  {get;set;} int = 0;
       [ProtoMember(16)] public   pubNumber  {get;set;} int = 0;
       [ProtoMember(17)] public   msgCommonLabel  {get;set;} CommonLabel? = null;
       [ProtoMember(18)] public   recentVistorTime  {get;set;} int = 0;
       [ProtoMember(19)] public   strangerDeclare  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(20)] public   friendUin  {get;set;} long = 0L;
       [ProtoMember(21)] public   historyFlag  {get;set;} int = 0;
       [ProtoMember(22)] public   followflag  {get;set;} long = 0L;
    }

    [ProtoContract] class HotUserFeed(
       [ProtoMember(1)] public   feedId  {get;set;} string = "";
       [ProtoMember(2)] public   praiseCount  {get;set;} int = 0;
       [ProtoMember(3)] public   publishUid  {get;set;} long = 0L;
       [ProtoMember(4)] public   publishTime  {get;set;} int = 0;
    }

    [ProtoContract] class FreshFeedInfo(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   time  {get;set;} int = 0;
       [ProtoMember(3)] public   feedId  {get;set;} string = "";
       [ProtoMember(4)] public   feedType  {get;set;} long = 0L;
    }

    [ProtoContract] class CommonLabel(
       [ProtoMember(1)] public   lableId  {get;set;} int = 0;
       [ProtoMember(2)] public   lableMsgPre  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   lableMsgLast  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(4)] public   interstName  {get;set;} List<byte[]> = new();
       [ProtoMember(5)] public   interstType  {get;set;} List<int> = new();
    }

    [ProtoContract] class Face(
       [ProtoMember(1)] public   index  {get;set;} int = 0;
    }

    [ProtoContract] class StrangerInfo(
       [ProtoMember(1)] public   tinyid  {get;set;} long = 0L;
       [ProtoMember(2)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   age  {get;set;} int = 0;
       [ProtoMember(4)] public   gender  {get;set;} int = 0;
       [ProtoMember(5)] public   dating  {get;set;} int = 0;
       [ProtoMember(6)] public   listIdx  {get;set;} int = 0;
       [ProtoMember(7)] public   constellation  {get;set;} string = "";
       [ProtoMember(8)] public   profession  {get;set;} int = 0;
       [ProtoMember(9)] public   marriage  {get;set;} int = 0;
       [ProtoMember(10)] public   vipinfo  {get;set;} string = "";
       [ProtoMember(11)] public   recommend  {get;set;} int = 0;
       [ProtoMember(12)] public   godflag  {get;set;} int = 0;
       [ProtoMember(13)] public   charm  {get;set;} int = 0;
       [ProtoMember(14)] public   charmLevel  {get;set;} int = 0;
       [ProtoMember(15)] public   uin  {get;set;} long = 0L;
    }

    [ProtoContract] class HotTopic(
       [ProtoMember(1)] public   id  {get;set;} long = 0L;
       [ProtoMember(2)] public   title  {get;set;} string = "";
       [ProtoMember(3)] public   topicType  {get;set;} long = 0L;
       [ProtoMember(4)] public   total  {get;set;} long = 0L;
       [ProtoMember(5)] public   times  {get;set;} long = 0L;
       [ProtoMember(6)] public   historyTimes  {get;set;} long = 0L;
       [ProtoMember(7)] public   bgUrl  {get;set;} string = "";
       [ProtoMember(8)] public   url  {get;set;} string = "";
       [ProtoMember(9)] public   extraInfo  {get;set;} string = "";
    }

    [ProtoContract] class DateEvent(
       [ProtoMember(1)] public   eventId  {get;set;} long = 0L;
       [ProtoMember(2)] public   time  {get;set;} int = 0;
       [ProtoMember(3)] public   type  {get;set;} int = 0;
       [ProtoMember(4)] public   msgUserInfo  {get;set;} StrangerInfo? = null;
       [ProtoMember(5)] public   msgDateInfo  {get;set;} AppointInfo? = null;
       [ProtoMember(6)] public   attendIdx  {get;set;} int = 0;
       [ProtoMember(7)] public   eventTips  {get;set;} string = "";
       [ProtoMember(8)] public   msgComment  {get;set;} DateComment? = null;
       [ProtoMember(9)] public   cancelEventId  {get;set;} long = 0L;
    }

    [ProtoContract] class AppointInfo(
       [ProtoMember(1)] public   msgAppointId  {get;set;} AppointID? = null;
       [ProtoMember(2)] public   msgAppointment  {get;set;} AppointContent? = null;
       [ProtoMember(3)] public   appointStatus  {get;set;} int = 0;
       [ProtoMember(4)] public   joinWording  {get;set;} string = "";
       [ProtoMember(5)] public   viewWording  {get;set;} string = "";
       [ProtoMember(6)] public   unreadCount  {get;set;} int = 0;
       [ProtoMember(7)] public   owner  {get;set;} int = 0;
       [ProtoMember(8)] public   join  {get;set;} int = 0;
       [ProtoMember(9)] public   view  {get;set;} int = 0;
       [ProtoMember(10)] public   commentWording  {get;set;} string = "";
       [ProtoMember(11)] public   commentNum  {get;set;} int = 0;
       [ProtoMember(12)] public   attendStatus  {get;set;} int = 0;
       [ProtoMember(13)] public   msgAppointmentEx  {get;set;} AppointInfoEx? = null;
    }

    [ProtoContract] class UserInfo(
       [ProtoMember(1)] public   uin  {get;set;} long = 0L;
       [ProtoMember(2)] public   nickname  {get;set;} byte[] = Array.Empty<byte>();
       [ProtoMember(3)] public   age  {get;set;} int = 0;
       [ProtoMember(4)] public   gender  {get;set;} int = 0;
       [ProtoMember(5)] public   avatar  {get;set;} byte[] = Array.Empty<byte>();
    }

    [ProtoContract] class ReplyInfo(
       [ProtoMember(1)] public   commentId  {get;set;} string = "";
       [ProtoMember(2)] public   msgStrangerInfo  {get;set;} StrangerInfo? = null;
    }
}
