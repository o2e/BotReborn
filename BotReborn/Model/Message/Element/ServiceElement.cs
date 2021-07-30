using System.Text.Unicode;

using Org.BouncyCastle.Ocsp;

namespace BotReborn.Model.Message.Element
{
    public class ServiceElement : IMessageElement
    {
        /// <summary>
        /// 新建Url分享
        /// </summary>
        public ServiceElement(string url, string title, string content, string image)
        {
            var str =
                $@"<?xml version=""1.0"" encoding=""utf-8""?><msg templateID=""12345"" action=""web"" brief=""[分享] {title}"" serviceID=""1"" url=""{url}""><item layout=""2""><picture cover=""{image}""/><title>{title}</title><summary>{content}</summary></item><source/></msg>";
            /*
                template := fmt.Sprintf(`<?xml version='1.0' encoding='UTF-8' standalone='yes'?><msg templateID="123" url="%s" serviceID="33" action="web" actionData="" brief="【链接】%s" flag="8"><item layout="2"><picture cover="%s"/><title>%s</title><summary>%s</summary></item></msg>`,
                    url, url, image, title, content,
                )
            */
            Id = 1;
            Content = str;
            ResId = url;
            SubType = "UrlShare";
        }

        /// <summary>
        /// 新建 rich xml
        /// </summary>
        /// <param name="template"></param>
        /// <param name="resId"></param>
        public ServiceElement(string template, long resId)
        {
            if (resId == 0)
            {
                Id = 60;
            }
            else
            {
                Id = int.Parse(resId.ToString());
            }

            Content = template;
            SubType = "xml";
        }

        /// <summary>
        /// 新建 rich json
        /// </summary>
        /// <param name="jsonContent"></param>
        public ServiceElement(string jsonContent)
        {
            Id = 1;
            Content = jsonContent;
            SubType = "json";
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public string ResId { get; set; }
        public string SubType { get; set; }
        public ElementType Type() => ElementType.Service;
    }
}
