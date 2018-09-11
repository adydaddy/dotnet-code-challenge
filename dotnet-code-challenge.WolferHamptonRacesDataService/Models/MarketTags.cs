using Newtonsoft.Json;

namespace dotnet_code_challenge.WolferHamptonRacesDataService.Models
{
    public partial class MarketTags
    {
        [JsonProperty("Places")]
        public long Places { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}