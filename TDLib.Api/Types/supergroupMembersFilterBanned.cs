using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SupergroupMembersFilter : Structure
    {

        public partial class supergroupMembersFilterBanned : SupergroupMembersFilter
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "supergroupMembersFilterBanned";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("query")]
                public string query_;

        }

    }

}