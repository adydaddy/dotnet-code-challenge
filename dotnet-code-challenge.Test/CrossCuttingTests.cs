using System.Xml;
using dotnet_code_challenge.CaulFieldRacesDataService.Models;
using dotnet_code_challenge.CrossCutting;
using Newtonsoft.Json;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public partial class CrossCuttingTests
    {
        [Fact]
        public void XmlDeserializer_Should_Throw_Exception_When_Provided_Jibbrish()
        {
            XmlDeserializer deserializer = new XmlDeserializer();
            Assert.Throws<XmlException>(() => { deserializer.Deserialize<CaulfieldRaceModel>("asdasda"); });
        }

        [Fact]
        public void JsonDeSerializer_Should_Throw_Exception_When_Provided_Jibbrish()
        {
            JsonDeserializer deserializer = new JsonDeserializer();
            Assert.Throws<JsonReaderException>(() => { deserializer.Deserialize<CaulfieldRaceModel>("asdasda"); });
        }


    }
}
