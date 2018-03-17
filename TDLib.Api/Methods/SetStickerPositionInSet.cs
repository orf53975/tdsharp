using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SetStickerPositionInSet : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "setStickerPositionInSet";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("sticker")]
        public InputFile Sticker { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("position")]
        public int Position { get; set; }

    }

}
