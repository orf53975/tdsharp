using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TextEntityType : Structure
    {

        public class TextEntityTypeBold : TextEntityType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "textEntityTypeBold";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
