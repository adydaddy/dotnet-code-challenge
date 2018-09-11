using System.Xml.Serialization;

namespace dotnet_code_challenge.CaulFieldRacesDataService.Models
{
    [XmlRoot(ElementName = "prices")]
    public class Prices
    {
        [XmlElement(ElementName = "price")]
        public Price Price { get; set; }
    }
}