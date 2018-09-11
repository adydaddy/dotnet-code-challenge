using Newtonsoft.Json;

namespace dotnet_code_challenge.Models
{
    public partial class Participant
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Tags")]
        public ParticipantTags Tags { get; set; }
    }
}