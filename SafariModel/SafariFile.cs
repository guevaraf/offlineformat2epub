namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("file")]
    public class SafariFile
    {
        [XmlAttribute("format")]
        public string Format { get; set; }
        [XmlAttribute("url")]
        public string Url { get; set; }
    }
}
