namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("date", Namespace = "http://purl.org/dc/elements/1.1/", IsNullable = true)]
    public class DcDate
    {
        [XmlAttribute("event", Namespace = "http://www.idpf.org/2007/opf")]
        public string Event { get; set; }
        [XmlText]
        public DateTime Value { get; set; }
    }
}
