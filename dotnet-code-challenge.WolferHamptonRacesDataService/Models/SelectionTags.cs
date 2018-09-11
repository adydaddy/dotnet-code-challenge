using Newtonsoft.Json;

namespace dotnet_code_challenge.WolferHamptonRacesDataService.Models
{
    public partial class SelectionTags
    {
        [JsonProperty("participant")]
        public long Participant { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}