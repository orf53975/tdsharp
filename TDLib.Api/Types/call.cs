using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class Call : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "call";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("is_outgoing")]
        public bool IsOutgoing { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("state")]
        public CallState State { get; set; }

    }

}
