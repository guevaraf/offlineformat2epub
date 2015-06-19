namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    public struct YesNo : IXmlSerializable
    {
        // we're just wrapping a bool
        private bool Value;

        // allow implicit casts to/from bool
        public static implicit operator bool(YesNo yn)
        {
            return yn.Value;
        }
        public static implicit operator YesNo(bool b)
        {
            return new YesNo() { Value = b };
        }

        // implement IXmlSerializable
        public XmlSchema GetSchema() { return null; }
        public void ReadXml(XmlReader reader)
        {
            Value = (reader.ReadElementContentAsString() == "yes");
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString((Value) ? "yes" : "no");
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
