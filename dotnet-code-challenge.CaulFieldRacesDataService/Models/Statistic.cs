using System.Xml.Serialization;

namespace dotnet_code_challenge.Models.CaulfieldRace
{
    [XmlRoot(ElementName = "statistic")]
    public class Statistic
    {
        [XmlAttribute(AttributeName = "firsts")]
        public string Firsts { get; set; }
        [XmlAttribute(AttributeName = "seconds")]
        public string Seconds { get; set; }
        [XmlAttribute(AttributeName = "thirds")]
        public string Thirds { get; set; }
        [XmlAttribute(AttributeName = "total")]
        public string Total { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }
}