using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateInstalledStickerSets : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateInstalledStickerSets";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_masks")]
                public bool IsMasks { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_set_ids")]
                public string[] StickerSetIds { get; set; }

        }

    }

}
