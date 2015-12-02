using System.Collections.Generic;
using Newtonsoft.Json;

namespace MbTest4Net.Model
{
    [JsonObject]
    internal class ImposterJson
    {
        [JsonProperty("imposters")]
        public List<Imposter> Imposters { get; set; }
    }

    [JsonObject]
    public class Imposter : ModelBase
    {
        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("stubs")]
        public List<Stub> Stubs { get; set; }
    }
}