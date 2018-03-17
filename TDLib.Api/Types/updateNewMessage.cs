using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateNewMessage : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateNewMessage";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message")]
                public Message Message { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("disable_notification")]
                public bool DisableNotification { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("contains_mention")]
                public bool ContainsMention { get; set; }

        }

    }

}
