using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class removeContacts : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "removeContacts";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_ids")]
                public int[] user_ids_;

        }

    }

}