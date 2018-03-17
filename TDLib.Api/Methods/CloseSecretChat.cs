using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class CloseSecretChat : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "closeSecretChat";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("secret_chat_id")]
        public int SecretChatId { get; set; }

    }

}
