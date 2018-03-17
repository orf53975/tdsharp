using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class FileType : Structure
    {

        public class FileTypeSecret : FileType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "fileTypeSecret";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
