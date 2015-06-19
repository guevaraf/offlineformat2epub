namespace SafariOnlineFormatConverter.Safari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public enum SectionType
    {
        [XmlEnum("")]
        None,
        [XmlEnum("preface")]
        Preface,
        [XmlEnum("dedication")]
        Dedication,
        [XmlEnum("chapter")]
        Chapter,
        [XmlEnum("sect1")]
        Section1
    }
}
