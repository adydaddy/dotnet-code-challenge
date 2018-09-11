using Newtonsoft.Json;

namespace dotnet_code_challenge.Models
{
    public partial class Market
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Selections")]
        public Selection[] Selections { get; set; }

        [JsonProperty("Tags")]
        public MarketTags Tags { get; set; }
    }
}