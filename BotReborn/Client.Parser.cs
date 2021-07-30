using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Model;
using BotReborn.Model.Message;
using BotReborn.Model.Message.Element;
using BotReborn.Protos;

namespace BotReborn
{
    partial class Client
    {
        public PrivateMessage ParsePrivateMessage(Message m)
        {
            var friend = Friends.FirstOrDefault(_ => _.Uin == m.Head.FromUin);
            Sender sender;
            if (friend is null)
            {
                sender = new Sender() { Uin = m.Head.FromUin, NickName = m.Head.FromNick };
            }
            else
            {
                sender = new Sender() { Uin = friend.Uin, NickName = friend.NickName, IsFriend = true };
            }

            var ret = new PrivateMessage()
            {
                Id = m.Head.MsgSeq,
                Target = m.Head.ToUin,
                Time = m.Head.MsgTime,
                Sender = sender,
                Self = Uin,
                Elements = ((Func<IMessageElement[]>)(() =>
               {
                   if (m.Body.RichText.Ptt != null)
                   {
                       return new IMessageElement[]
                       {
                           new VoiceElement()
                           {
                               Name = m.Body.RichText.Ptt?.FileName,
                               Md5 = m.Body.RichText.Ptt?.FileMd5.ToByteArray(),
                               Size = (int) m.Body.RichText.Ptt?.FileSize,
                               Url = m.Body.RichText.Ptt?.DownPara.ToString()
                           }
                       };
                   }

                   return null;//todo
               }))(),

            };
            if (m.Body.RichText.Attr is not null)
            {
                ret.InternalId = m.Body.RichText.Attr.Random;
            }

            return ret;
        }
    }
}
