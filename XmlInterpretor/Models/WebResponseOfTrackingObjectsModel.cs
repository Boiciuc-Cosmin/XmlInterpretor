using System.Xml;
using System.Xml.Serialization;

namespace WpfApplication.Models {
    [XmlRoot(ElementName = "WebResponseOfArrayOfTrackingObjectoORFVqe_S", Namespace = "http://schemas.datacontract.org/2004/07/Grollmus.TstCloud.Base.Web.Models")]
    public class WebResponseOfTrackingObjectsModel {
        [XmlElement(ElementName = "dataContent", Namespace = "http://schemas.datacontract.org/2004/07/Grollmus.TstCloud.Business.Web.Models")]
        public DataContentModel DataContent { get; set; }
    }


}
