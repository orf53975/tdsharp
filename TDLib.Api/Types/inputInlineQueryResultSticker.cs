using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputInlineQueryResult : Structure
    {

        public class InputInlineQueryResultSticker : InputInlineQueryResult
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputInlineQueryResultSticker";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_url")]
                public string ThumbnailUrl { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_url")]
                public string StickerUrl { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_width")]
                public int StickerWidth { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_height")]
                public int StickerHeight { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup ReplyMarkup { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("input_message_content")]
                public InputMessageContent InputMessageContent { get; set; }

        }

    }

}
