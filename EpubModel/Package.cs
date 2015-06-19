namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("package", Namespace = "http://www.idpf.org/2007/opf", IsNullable = true)]
    public class Package
    {
        [XmlAttribute("unique-identifier")]
        public string Id { get; set; }
        [XmlAttribute("version")]
        public string Version { get; set; }
        [XmlElement("metadata")]
        public Metadata Metadata { get; set; }
        [XmlElement("manifest")]
        public Manifest Manifest { get; set; }
        [XmlElement("spine")]
        public Spine Spine { get; set; }
        [XmlElement("guide")]
        public Guide Guide { get; set; }

        public static IDictionary<string, string> GetNamespaces()
        {
            return new Dictionary<string, string>()
            {
                {"dc", "http://purl.org/dc/elements/1.1/"},
                {"opf", "http://www.idpf.org/2007/opf"},
                {"dcterms", "http://purl.org/dc/terms/"},
                {"xsi", "http://www.w3.org/2001/XMLSchema-instance"}
            };
        }
    }
}
