using System.Collections.Generic;
using Newtonsoft.Json;

namespace MbTest4Net.Model
{
    public class ImposterJson
    {
        [JsonProperty("imposters")]
        public List<Imposter> Imposters { get; set; }     
    }

    public class Imposter
    {
        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("stubs")]
        public List<Stub> Stubs { get; set; }
    }
}