using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class DatedFile : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "datedFile";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("file")]
            public File File { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }
        }
    }
}