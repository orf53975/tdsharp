using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthorizationState : Structure
    {

        public class AuthorizationStateClosed : AuthorizationState
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateClosed";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
