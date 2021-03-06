using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class CheckPhoneNumberVerificationCode : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "checkPhoneNumberVerificationCode";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("code")]
            public string Code { get; set; }
        }
    }
}