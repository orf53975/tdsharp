using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class StorageStatisticsByFileType : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "storageStatisticsByFileType";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_type")]
            public FileType FileType { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("size")]
            public long Size { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("count")]
            public int Count { get; set; }
        }
    }
}