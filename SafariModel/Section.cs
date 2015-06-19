namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("section")]
    public class Section
    {
        [XmlElement("heading")]
        public string Heading { get; set; }
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("type")]
        public SectionType Type { get; set; }
        [XmlElement("url")]
        public string Url { get; set; }
        [XmlElement("section")]
        public Section[] Subsections { get; set; }
    }
}
