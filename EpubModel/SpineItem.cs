namespace SafariOnlineFormatConverter.Epub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    [XmlRoot("itemref")]
    public class SpineItem
    {
        private YesNo _linearValue;

        [XmlAttribute("idref")]
        public string Id { get; set; }
        [XmlAttribute("linear")]
        public string Linear { get; set; }
        [XmlIgnore]
        public bool IsLinear {
            get
            {
                return Linear.ToLower() == "yes";
            }
        }
    }
}
