using System.Xml.Serialization;

namespace dotnet_code_challenge.Models.CaulfieldRace
{
    [XmlRoot(ElementName = "horse")]
    public class Horse
    {
        [XmlAttribute(AttributeName = "number")]
        public string _Number { get; set; }
        [XmlAttribute(AttributeName = "age")]
        public string Age { get; set; }
        [XmlElement(ElementName = "barrier")]
        public string Barrier { get; set; }
        [XmlAttribute(AttributeName = "colour")]
        public string Colour { get; set; }
        [XmlElement(ElementName = "colours")]
        public string Colours { get; set; }
        [XmlAttribute(AttributeName = "country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "current_blinker_ind")]
        public string Current_blinker_ind { get; set; }
        [XmlAttribute(AttributeName = "foaling_date")]
        public string Foaling_date { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "jockey")]
        public Jockey Jockey { get; set; }
        [XmlElement(ElementName = "last_four_starts")]
        public string Last_four_starts { get; set; }
        [XmlElement(ElementName = "last_ten_starts")]
        public string Last_ten_starts { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "number")]
        public string Number { get; set; }
        [XmlElement(ElementName = "owners")]
        public string Owners { get; set; }
        [XmlAttribute(AttributeName = "Price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "prizemoney_won")]
        public string Prizemoney_won { get; set; }
        [XmlAttribute(AttributeName = "sex")]
        public string Sex { get; set; }
        [XmlElement(ElementName = "trainer")]
        public Trainer Trainer { get; set; }
        [XmlElement(ElementName = "training_location")]
        public string Training_location { get; set; }
        [XmlElement(ElementName = "weight")]
        public Weight Weight { get; set; }
    }
}