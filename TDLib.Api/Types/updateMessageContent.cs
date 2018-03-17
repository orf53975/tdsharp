using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateMessageContent : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateMessageContent";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_content")]
                public MessageContent NewContent { get; set; }

        }

    }

}
