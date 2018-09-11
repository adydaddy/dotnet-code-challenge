using System.Xml.Serialization;

namespace dotnet_code_challenge.Models.CaulfieldRace
{
    [XmlRoot(ElementName = "prices")]
    public class Prices
    {
        [XmlElement(ElementName = "price")]
        public Price Price { get; set; }
    }
}