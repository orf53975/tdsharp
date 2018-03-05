using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateChatUnreadMentionCount : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateChatUnreadMentionCount";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long? chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("unread_mention_count")]
                public int? unread_mention_count_;

        }

    }

}