using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SetScopeNotificationSettings : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "setScopeNotificationSettings";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("scope")]
            public NotificationSettingsScope Scope { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("notification_settings")]
            public ScopeNotificationSettings NotificationSettings { get; set; }
        }
    }
}