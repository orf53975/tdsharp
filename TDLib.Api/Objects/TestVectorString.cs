using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class TestVectorString : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "testVectorString";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("value")]
            public string[] Value { get; set; }
        }
    }
}