namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public class ContentType
    {
        [XmlAttribute("role")]
        public string Role { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
