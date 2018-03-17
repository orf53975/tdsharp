using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class UserProfilePhotos : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "userProfilePhotos";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("photos")]
        public Photo[] Photos { get; set; }

    }

}
