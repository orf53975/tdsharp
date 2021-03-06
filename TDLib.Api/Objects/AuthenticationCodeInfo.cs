using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class AuthenticationCodeInfo : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "authenticationCodeInfo";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("phone_number")]
            public string PhoneNumber { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public AuthenticationCodeType Type { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("next_type")]
            public AuthenticationCodeType NextType { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("timeout")]
            public int Timeout { get; set; }
        }
    }
}