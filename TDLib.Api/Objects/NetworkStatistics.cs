using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class NetworkStatistics : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "networkStatistics";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("since_date")]
            public int SinceDate { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("entries")]
            public NetworkStatisticsEntry[] Entries { get; set; }
        }
    }
}