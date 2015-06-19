namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("guide")]
    public class Guide
    {
        [XmlElement("reference")]
        public GuideReference[] References { get; set; }
    }
}
