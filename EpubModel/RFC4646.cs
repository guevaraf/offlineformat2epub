namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlType(Namespace = "http://purl.org/dc/terms/")]
    public class RFC4646 : DcLanguage
    {
        // Because of: http://siderite.blogspot.com/2014/01/deserializingserializing-xml-that.html
    }
}
