using System.Xml.Serialization;

namespace dotnet_code_challenge.Models.CaulfieldRace
{
    [XmlRoot(ElementName = "race")]
    public class Race
    {
        [XmlElement(ElementName = "distance")]
        public Distance Distance { get; set; }
        [XmlElement(ElementName = "horses")]
        public Horses Horses { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlElement(ElementName = "NumberOfRunners")]
        public string NumberOfRunners { get; set; }
        [XmlElement(ElementName = "prices")]
        public Prices Prices { get; set; }
        [XmlElement(ElementName = "start_time")]
        public string Start_time { get; set; }
        [XmlAttribute(AttributeName = "Status")]
        public string Status { get; set; }
    }
}