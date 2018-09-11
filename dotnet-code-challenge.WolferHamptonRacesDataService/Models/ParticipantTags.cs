using Newtonsoft.Json;

namespace dotnet_code_challenge.WolferHamptonRacesDataService.Models
{
    public partial class ParticipantTags
    {
        [JsonProperty("Weight")]
        public string Weight { get; set; }

        [JsonProperty("Drawn")]
        public long Drawn { get; set; }

        [JsonProperty("Jockey")]
        public string Jockey { get; set; }

        [JsonProperty("Number")]
        public long Number { get; set; }

        [JsonProperty("Trainer")]
        public string Trainer { get; set; }
    }
}