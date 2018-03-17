using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SupergroupMembersFilter : Structure
    {

        public class SupergroupMembersFilterAdministrators : SupergroupMembersFilter
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "supergroupMembersFilterAdministrators";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
