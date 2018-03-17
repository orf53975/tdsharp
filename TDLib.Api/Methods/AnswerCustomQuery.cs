using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class AnswerCustomQuery : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "answerCustomQuery";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("custom_query_id")]
        public string CustomQueryId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("data")]
        public string Data { get; set; }

    }

}
