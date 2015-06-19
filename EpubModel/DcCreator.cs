namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("creator", Namespace = "http://purl.org/dc/elements/1.1/")]
    public class DcCreator
    {
        [XmlAttribute("file-as", Namespace = "http://www.idpf.org/2007/opf")]
        public string FileAs { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
