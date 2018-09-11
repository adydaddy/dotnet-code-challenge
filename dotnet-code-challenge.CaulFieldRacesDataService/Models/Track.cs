using System.Xml.Serialization;

namespace dotnet_code_challenge.CaulFieldRacesDataService.Models
{
    [XmlRoot(ElementName = "track")]
    public class Track
    {
        [XmlAttribute(AttributeName = "club")]
        public string Club { get; set; }
        [XmlAttribute(AttributeName = "condition")]
        public string Condition { get; set; }
        [XmlAttribute(AttributeName = "country")]
        public string Country { get; set; }
        [XmlAttribute(AttributeName = "location")]
        public string Location { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "state")]
        public string State { get; set; }
        [XmlAttribute(AttributeName = "TranslatedName")]
        public string TranslatedName { get; set; }
    }
}