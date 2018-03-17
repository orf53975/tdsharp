using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class UserPrivacySetting : Structure
    {

        public class UserPrivacySettingAllowCalls : UserPrivacySetting
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingAllowCalls";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
