using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetSavedOrderInfo : Function<OrderInfo>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getSavedOrderInfo";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}