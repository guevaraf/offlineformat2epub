namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public class MetadataMeta
    {
        [XmlAttribute("content")]
        public string Content { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
