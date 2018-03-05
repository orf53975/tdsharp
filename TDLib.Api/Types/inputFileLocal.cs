using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputFile : Structure
    {

        public partial class inputFileLocal : InputFile
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inputFileLocal";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("path")]
                public string path_;

        }

    }

}