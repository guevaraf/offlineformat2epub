namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("reference")]
    public class GuideReference
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("title")]
        public string Title { get; set; }
        [XmlAttribute("href")]
        public string Url { get; set; }
    }
}
