using System.Text.Json.Serialization;

namespace BotReborn.Model
{
    public class QqFace
    {
        [JsonPropertyName("sysface")]
        public Sysface[] Sysface { get; set; }

        [JsonPropertyName("emoji")]
        public Emoji[] Emoji { get; set; }
    }

    public class Emoji
    {
        [JsonPropertyName("QSid")]
        public string QSid { get; set; }

        [JsonPropertyName("QCid")]
        public string QCid { get; set; }

        [JsonPropertyName("AQLid")]
        public string AqLid { get; set; }

        [JsonPropertyName("QDes")]
        public string QDes { get; set; }

        [JsonPropertyName("EMCode")]
        public string EmCode { get; set; }
    }

    public class Sysface
    {
        [JsonPropertyName("QSid")]
        public string QSid { get; set; }

        [JsonPropertyName("QDes")]
        public string QDes { get; set; }

        [JsonPropertyName("IQLid")]
        public string IqLid { get; set; }

        [JsonPropertyName("AQLid")]
        public string AqLid { get; set; }

        [JsonPropertyName("EMCode")]
        public string EmCode { get; set; }

        [JsonPropertyName("isStatic")]
        public string IsStatic { get; set; }

        [JsonPropertyName("QHide")]
        public string QHide { get; set; }

        [JsonPropertyName("AniStickerType")]
        public long? AniStickerType { get; set; }

        [JsonPropertyName("AniStickerPackId")]
        public string AniStickerPackId { get; set; }

        [JsonPropertyName("AniStickerId")]
        public string AniStickerId { get; set; }

        [JsonPropertyName("isCMEmoji")]
        public string IsCmEmoji { get; set; }
    }
}
