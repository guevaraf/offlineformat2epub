namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("language", Namespace = "http://purl.org/dc/elements/1.1/"),
    XmlInclude(typeof(RFC4646))]
    public class DcLanguage
    {
        [XmlAttribute("type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Type { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
