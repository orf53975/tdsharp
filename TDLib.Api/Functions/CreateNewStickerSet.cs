using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class CreateNewStickerSet : Function<StickerSet>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "createNewStickerSet";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_masks")]
            public bool IsMasks { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("stickers")]
            public InputSticker[] Stickers { get; set; }
        }
    }
}