using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PageBlock : Structure
    {

        public class PageBlockSubtitle : PageBlock
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockSubtitle";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("subtitle")]
                public RichText Subtitle { get; set; }

        }

    }

}
