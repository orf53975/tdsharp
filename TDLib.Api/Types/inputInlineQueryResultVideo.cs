using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputInlineQueryResult : Structure
    {

        public class InputInlineQueryResultVideo : InputInlineQueryResult
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputInlineQueryResultVideo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string Description { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_url")]
                public string ThumbnailUrl { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_url")]
                public string VideoUrl { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("mime_type")]
                public string MimeType { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_width")]
                public int VideoWidth { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_height")]
                public int VideoHeight { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_duration")]
                public int VideoDuration { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup ReplyMarkup { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("input_message_content")]
                public InputMessageContent InputMessageContent { get; set; }

        }

    }

}
