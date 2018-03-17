using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class Sessions : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "sessions";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("sessions")]
        public Session[] Sessions_ { get; set; }

    }

}
