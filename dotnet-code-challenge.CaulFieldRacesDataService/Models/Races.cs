using System.Xml.Serialization;

namespace dotnet_code_challenge.CaulFieldRacesDataService.Models
{
    [XmlRoot(ElementName = "races")]
    public class Races
    {
        [XmlElement(ElementName = "race")]
        public Race Race { get; set; }
    }
}