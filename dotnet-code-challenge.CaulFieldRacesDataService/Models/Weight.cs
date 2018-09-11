using System.Collections.Generic;
using System.Xml.Serialization;

namespace dotnet_code_challenge.CaulFieldRacesDataService.Models
{


    [XmlRoot(ElementName = "weight")]
    public class Weight
    {
        [XmlAttribute(AttributeName = "allocated")]
        public string Allocated { get; set; }
        [XmlAttribute(AttributeName = "total")]
        public string Total { get; set; }
    }

}


