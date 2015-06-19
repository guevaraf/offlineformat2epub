namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public class FormatType
    {
        [XmlAttribute("format")]
        public string Format { get; set; }
        [XmlAttribute("source")]
        public string Source { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
