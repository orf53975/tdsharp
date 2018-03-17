using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetChatEventLog : Method<ChatEvents>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getChatEventLog";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("from_event_id")]
        public string FromEventId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("filters")]
        public ChatEventLogFilters Filters { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("user_ids")]
        public int[] UserIds { get; set; }

    }

}
