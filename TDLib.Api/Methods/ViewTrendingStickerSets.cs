using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class ViewTrendingStickerSets : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "viewTrendingStickerSets";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("sticker_set_ids")]
        public string[] StickerSetIds { get; set; }

    }

}
