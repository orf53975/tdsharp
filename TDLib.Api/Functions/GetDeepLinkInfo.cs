using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetDeepLinkInfo : Function<DeepLinkInfo>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getDeepLinkInfo";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("link")]
            public string Link { get; set; }
        }
    }
}