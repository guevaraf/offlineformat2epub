namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("manifest", IsNullable = true)]
    public class Manifest
    {
        [XmlElement("item")]
        public ManifestItem[] Items { get; set; }
    }
}
