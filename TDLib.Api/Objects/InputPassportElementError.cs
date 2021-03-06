using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class InputPassportElementError : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "inputPassportElementError";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public PassportElementType Type { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("source")]
            public InputPassportElementErrorSource Source { get; set; }
        }
    }
}