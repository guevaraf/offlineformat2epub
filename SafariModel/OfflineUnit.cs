namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("offlineunit")]
    public class OfflineUnit
    {
        [XmlAttribute("role")]
        public string Role { get; set; }
        [XmlAttribute("tokens")]
        public int Tokens { get; set; }
        [XmlAttribute("linkid")]
        public string LinkId { get; set; }
        [XmlElement("file")]
        public SafariFile[] Files { get; set; }
    }
}
