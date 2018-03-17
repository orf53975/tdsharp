using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateSecretChat : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateSecretChat";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("secret_chat")]
                public SecretChat SecretChat { get; set; }

        }

    }

}
