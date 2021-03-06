using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputPassportElementErrorSource : Object
        {
            public class InputPassportElementErrorSourceUnspecified : InputPassportElementErrorSource
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementErrorSourceUnspecified";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("element_hash")]
                public byte[] ElementHash { get; set; }
            }
        }
    }
}