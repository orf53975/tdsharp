using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Sessions : Structure
    {

        public partial class sessions : Sessions
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "sessions";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sessions")]
                public Session.session[] sessions_;

        }

    }

}