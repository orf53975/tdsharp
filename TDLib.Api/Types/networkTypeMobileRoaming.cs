using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class NetworkType : Structure
    {

        public class NetworkTypeMobileRoaming : NetworkType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "networkTypeMobileRoaming";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
