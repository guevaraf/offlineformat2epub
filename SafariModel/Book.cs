namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("book", IsNullable = true)]
    public class Book
    {
        [XmlElement("cdalicensor")]
        public CDALicensor CDALicensor { get; set; }
        [XmlElement("contenttype")]
        public ContentType ContentType { get; set; }
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("language")]
        public string Language { get; set; }
        [XmlElement("rights")]
        public string Rights { get; set; }
        [XmlElement("formattypes")]
        public FormatTypes FormatTypes { get; set; }
        [XmlElement("section")]
        public Section[] Sections { get; set; }
        [XmlElement("offlinecontentlist")]
        public OfflineContentList OfflineContents { get; set; }
        [XmlElement("tableofcontents")]
        public TableOfContents TableOfContents { get; set; }
    }
}
