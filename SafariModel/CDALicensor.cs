namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public class CDALicensor
    {
        [XmlAttribute("code")]
        public string Code { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
