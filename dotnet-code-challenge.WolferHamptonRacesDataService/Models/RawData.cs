using System;
using Newtonsoft.Json;

namespace dotnet_code_challenge.WolferHamptonRacesDataService.Models
{
    public partial class RawData
    {
        [JsonProperty("FixtureName")]
        public string FixtureName { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("StartTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("Sequence")]
        public long Sequence { get; set; }

        [JsonProperty("Tags")]
        public RawDataTags Tags { get; set; }

        [JsonProperty("Markets")]
        public Market[] Markets { get; set; }

        [JsonProperty("Participants")]
        public Participant[] Participants { get; set; }
    }
}