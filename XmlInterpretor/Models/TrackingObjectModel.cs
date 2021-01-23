using System.Xml;
using System.Xml.Serialization;

namespace WpfApplication.Models {

    public class TrackingObjectModel {
        [XmlElement(ElementName = "id", Namespace = "http://schemas.datacontract.org/2004/07/Grollmus.TstCloud.Business.Base")]
        public int? Id { get; set; }
        [XmlElement(ElementName = "BrowserEnvironment", Namespace = "http://schemas.datacontract.org/2004/07/Grollmus.TstCloud.Business")]
        public BrowserEnvironmentModel BrowserEnviroment { get; set; }
        [XmlElement(ElementName = "BrowserEnvironmentId")]
        public int BrowserEnvironmentId { get; set; }
    }


}
