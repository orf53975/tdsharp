using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class ChangeStickerSet : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "changeStickerSet";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("is_installed")]
        public bool IsInstalled { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

    }

}
