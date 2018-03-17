using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class LinkState : Structure
    {

        public class LinkStateIsContact : LinkState
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "linkStateIsContact";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
