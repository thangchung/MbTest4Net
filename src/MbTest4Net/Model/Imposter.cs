using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MbTest4Net.Attribute;
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
        [Integer] [Min(1)]
        public int Port { get; set; }

        [JsonProperty("protocol")]
        [Required]
        public string Protocol { get; set; }

        [JsonProperty("stubs")]
        public List<Stub> Stubs { get; set; }
    }
}