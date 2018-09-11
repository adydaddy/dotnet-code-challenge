using System;
using Newtonsoft.Json;

namespace dotnet_code_challenge.WolferHamptonRacesDataService.Models
{
    public partial class WolferHamptonRaceModel
    {
        [JsonProperty("FixtureId")]
        public string FixtureId { get; set; }

        [JsonProperty("Timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("RawData")]
        public RawData RawData { get; set; }
    }

}
