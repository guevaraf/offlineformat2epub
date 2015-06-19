namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("spine")]
    public class Spine
    {
        [XmlAttribute("toc")]
        public string Toc { get; set; }
        [XmlElement("itemref")]
        public SpineItem[] Items { get; set; }
    }
}
