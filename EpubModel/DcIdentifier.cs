namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("identifier", Namespace="http://purl.org/dc/elements/1.1/")]
    public class DcIdentifier
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("scheme", Namespace = "http://www.idpf.org/2007/opf")]
        public string Scheme { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
