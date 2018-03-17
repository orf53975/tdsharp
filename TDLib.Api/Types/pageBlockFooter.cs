using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PageBlock : Structure
    {

        public class PageBlockFooter : PageBlock
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockFooter";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("footer")]
                public RichText Footer { get; set; }

        }

    }

}
