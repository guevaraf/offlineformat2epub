namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public class Metadata
    {
        [XmlElement("rights", Namespace="http://purl.org/dc/elements/1.1/")]
        public string Rights { get; set; }
        [XmlElement("source", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Source { get; set; }
        [XmlElement("title", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Title { get; set; }
        [XmlElement("date", Namespace = "http://purl.org/dc/elements/1.1/")]
        public DcDate[] Dates { get; set; }
        [XmlElement("identifier", Namespace = "http://purl.org/dc/elements/1.1/")]
        public DcIdentifier Identifier { get; set; }
        [XmlElement("language", Namespace = "http://purl.org/dc/elements/1.1/")]
        public DcLanguage Language { get; set; }
        [XmlElement("creator", Namespace = "http://purl.org/dc/elements/1.1/")]
        public DcCreator Creator { get; set; }
        
        [XmlElement("meta")]
        public MetadataMeta Meta { get; set; }
    }
}
