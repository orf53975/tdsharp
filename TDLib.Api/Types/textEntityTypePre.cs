using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TextEntityType : Structure
    {

        public class TextEntityTypePre : TextEntityType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "textEntityTypePre";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
