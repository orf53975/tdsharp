using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getFileMimeType : Method<Text>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getFileMimeType";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file_name")]
                public string file_name_;

        }

    }

}