using Newtonsoft.Json;

namespace dotnet_code_challenge.Models
{
    public partial class Selection
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("Tags")]
        public SelectionTags Tags { get; set; }
    }
}