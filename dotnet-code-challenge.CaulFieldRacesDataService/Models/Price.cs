using System.Xml.Serialization;

namespace dotnet_code_challenge.Models.CaulfieldRace
{
    [XmlRoot(ElementName = "price")]
    public class Price
    {
        [XmlElement(ElementName = "horses")]
        public Horses Horses { get; set; }
        [XmlElement(ElementName = "priceType")]
        public string PriceType { get; set; }
    }
}