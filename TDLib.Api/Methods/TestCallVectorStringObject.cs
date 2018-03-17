using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class TestCallVectorStringObject : Method<TestVectorStringObject>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "testCallVectorStringObject";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("x")]
        public TestString[] X { get; set; }

    }

}
