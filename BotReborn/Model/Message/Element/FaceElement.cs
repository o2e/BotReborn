using System;

namespace BotReborn.Model.Message.Element
{
    public class FaceElement : IMessageElement
    {
        /// <summary>
        /// 新建表情
        /// </summary>
        /// <param name="index"></param>
        public FaceElement(int index)
        {
            var map = new QqFaceMap().ReadMap().Result;
            if (map.TryGetValue(index, out string name))
            {
                if (name == "")
                {
                    name = "未知表情";
                }

                Name = name;
                Index = index;
                return;
            }

            throw new IndexOutOfRangeException();
        }

        public int Index { get; set; }
        public string Name { get; set; }
        public ElementType Type() => ElementType.Face;
    }
}
