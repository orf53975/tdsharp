using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class DeviceToken : Structure
    {

        public class DeviceTokenApplePush : DeviceToken
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "deviceTokenApplePush";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("device_token")]
                public string DeviceToken { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_app_sandbox")]
                public bool IsAppSandbox { get; set; }

        }

    }

}
