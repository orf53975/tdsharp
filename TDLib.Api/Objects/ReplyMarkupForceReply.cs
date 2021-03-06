using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ReplyMarkup : Object
        {
            public class ReplyMarkupForceReply : ReplyMarkup
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "replyMarkupForceReply";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_personal")]
                public bool IsPersonal { get; set; }
            }
        }
    }
}