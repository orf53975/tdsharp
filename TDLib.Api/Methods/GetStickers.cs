using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetStickers : Method<Stickers>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getStickers";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("limit")]
        public int Limit { get; set; }

    }

}
