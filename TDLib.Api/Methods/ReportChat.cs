using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class ReportChat : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "reportChat";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("reason")]
        public ChatReportReason Reason { get; set; }

    }

}
