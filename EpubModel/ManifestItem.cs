namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("item")]
    public class ManifestItem
    {
        [XmlAttribute("media-type")]
        public string MediaType { get; set; }
        [XmlAttribute("href")]
        public string Url { get; set; }
        [XmlAttribute("id")]
        public string Id { get; set; }
    }
}
