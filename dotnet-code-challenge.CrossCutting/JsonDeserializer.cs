using Newtonsoft.Json;

namespace dotnet_code_challenge.CrossCutting
{
    public class JsonDeserializer : Deserializer
    {
        public override T Deserialize<T>(string objectContent)
        {
            return JsonConvert.DeserializeObject<T>(objectContent);
        }
    }
}