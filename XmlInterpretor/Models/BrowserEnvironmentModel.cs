using System.Xml;
using System.Xml.Serialization;

namespace WpfApplication.Models {

    public class BrowserEnvironmentModel {
        [XmlElement(ElementName = "id", Namespace = "http://schemas.datacontract.org/2004/07/Grollmus.TstCloud.Business.Base")]
        public int? Id { get; set; }
        [XmlElement("browserLanguage")]
        public string BrowserLanguage { get; set; }
        [XmlElement("deviceId")]
        public string DeviceId { get; set; }
        [XmlElement("edition")]
        public string Edition { get; set; }
        [XmlElement("operatingSystem")]
        public string OperatingSystem { get; set; }
        [XmlElement("screenSize")]
        public string ScreenSize { get; set; }
        [XmlElement("sessionEnd")]
        public string SessionEnd { get; set; }
        [XmlElement("sessionStart")]
        public string SessionStart { get; set; }
        [XmlElement("siemensIntranet")]
        public bool Intranet { get; set; }
        [XmlElement("userAgent")]
        public string UserAgent { get; set; }
        [XmlElement("version")]
        public string Version { get; set; }

    }


}
