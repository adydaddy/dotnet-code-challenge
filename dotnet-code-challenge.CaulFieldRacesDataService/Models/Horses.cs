using System.Collections.Generic;
using System.Xml.Serialization;

namespace dotnet_code_challenge.Models.CaulfieldRace
{
    [XmlRoot(ElementName = "horses")]
    public class Horses
    {
        [XmlElement(ElementName = "horse")]
        public List<Horse> Horse { get; set; }
    }
}