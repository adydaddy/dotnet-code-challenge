using System.Xml.Serialization;

namespace dotnet_code_challenge.CaulFieldRacesDataService.Models
{
    [XmlRoot(ElementName = "statistics")]
    public class Statistics
    {
        [XmlElement(ElementName = "statistic")]
        public Statistic Statistic { get; set; }
    }
}