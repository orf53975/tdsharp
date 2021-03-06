using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class ChatEvent : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "chatEvent";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public Int64 Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("action")]
            public ChatEventAction Action { get; set; }
        }
    }
}