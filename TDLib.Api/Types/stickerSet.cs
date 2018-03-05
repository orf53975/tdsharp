using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class StickerSet : Structure
    {

        public partial class stickerSet : StickerSet
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "stickerSet";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("name")]
                public string name_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_installed")]
                public bool? is_installed_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_archived")]
                public bool? is_archived_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_official")]
                public bool? is_official_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_masks")]
                public bool? is_masks_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_viewed")]
                public bool? is_viewed_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("stickers")]
                public Sticker.sticker[] stickers_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("emojis")]
                public StickerEmojis.stickerEmojis[] emojis_;

        }

    }

}