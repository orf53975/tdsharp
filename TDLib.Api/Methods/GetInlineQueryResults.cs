using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetInlineQueryResults : Method<InlineQueryResults>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getInlineQueryResults";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("bot_user_id")]
        public int BotUserId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("user_location")]
        public Location UserLocation { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("offset")]
        public string Offset { get; set; }

    }

}
