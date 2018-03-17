using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class AnswerCallbackQuery : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "answerCallbackQuery";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("callback_query_id")]
        public string CallbackQueryId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("show_alert")]
        public bool ShowAlert { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("cache_time")]
        public int CacheTime { get; set; }

    }

}
