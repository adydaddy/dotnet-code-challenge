using System.Xml.Serialization;

namespace dotnet_code_challenge.CaulFieldRacesDataService.Models
{
    [XmlRoot(ElementName = "distance")]
    public class Distance
    {
        [XmlAttribute(AttributeName = "metres")]
        public string Metres { get; set; }
    }
}