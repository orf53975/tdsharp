using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateFavoriteStickers : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateFavoriteStickers";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_ids")]
                public int[] sticker_ids_;

        }

    }

}