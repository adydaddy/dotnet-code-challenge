using Newtonsoft.Json;

namespace dotnet_code_challenge.Models
{
    public partial class MarketTags
    {
        [JsonProperty("Places")]
        public long Places { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}