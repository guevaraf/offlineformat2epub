namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlType("formattypes")]
    public class FormatTypes
    {
        [XmlAttribute("recommended")]
        public string Recommended { get; set; }

        [XmlElement("type")]
        public FormatType[] Types { get; set; }
    }
}
