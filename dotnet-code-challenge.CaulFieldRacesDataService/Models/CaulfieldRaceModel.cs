using System.Collections.Generic;
using System.Xml.Serialization;

namespace dotnet_code_challenge.CaulFieldRacesDataService.Models
{
    [XmlRoot(ElementName = "meeting")]
    public class CaulfieldRaceModel
    {
        [XmlElement(ElementName = "date")]
        public string Date { get; set; }
        [XmlElement(ElementName = "Meetingid")]
        public string Meetingid { get; set; }
        [XmlElement(ElementName = "MeetingType")]
        public string MeetingType { get; set; }
        [XmlElement(ElementName = "races")]
        public List<Races> Races { get; set; }
        [XmlElement(ElementName = "track")]
        public Track Track { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
    }
}