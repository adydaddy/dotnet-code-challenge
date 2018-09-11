using System.Xml.Serialization;

namespace dotnet_code_challenge.CaulFieldRacesDataService.Models
{
    [XmlRoot(ElementName = "trainer")]
    public class Trainer
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "statistics")]
        public Statistics Statistics { get; set; }
    }
}