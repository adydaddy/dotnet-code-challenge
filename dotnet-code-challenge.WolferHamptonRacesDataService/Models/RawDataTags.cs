using Newtonsoft.Json;

namespace dotnet_code_challenge.WolferHamptonRacesDataService.Models
{
    public partial class RawDataTags
    {
        [JsonProperty("CourseType")]
        public string CourseType { get; set; }

        [JsonProperty("Distance")]
        public string Distance { get; set; }

        [JsonProperty("Going")]
        public string Going { get; set; }

        [JsonProperty("Runners")]
        public long Runners { get; set; }

        [JsonProperty("MeetingCode")]
        public long MeetingCode { get; set; }

        [JsonProperty("TrackCode")]
        public string TrackCode { get; set; }

        [JsonProperty("Sport")]
        public string Sport { get; set; }
    }
}