using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class RemoveSavedAnimation : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "removeSavedAnimation";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("animation")]
        public InputFile Animation { get; set; }

    }

}
