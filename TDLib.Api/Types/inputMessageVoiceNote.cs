using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputMessageContent : Structure
    {

        public class InputMessageVoiceNote : InputMessageContent
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessageVoiceNote";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("voice_note")]
                public InputFile VoiceNote { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int Duration { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("waveform")]
                public byte[] Waveform { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText Caption { get; set; }

        }

    }

}
