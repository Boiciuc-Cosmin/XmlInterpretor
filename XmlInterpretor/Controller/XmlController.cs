using FileHandler.XmlHandlers;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using WpfApplication.Models;

namespace WpfApplication.Controller {
    public class XmlController {

        public async Task<WebResponseOfTrackingObjectsModel> GetAllXmlData(string filePath) {
            if (string.IsNullOrEmpty(filePath)) {
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or empty", nameof(filePath));
            }
            if (CheckIfCanDeserialize(filePath)) {
                return await XmlHandler.DeserializeXml<WebResponseOfTrackingObjectsModel>(filePath);
            }
            return new WebResponseOfTrackingObjectsModel();
        }

        private bool CheckIfCanDeserialize(string filePath) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(WebResponseOfTrackingObjectsModel));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open)) {
                if (xmlSerializer.CanDeserialize(XmlReader.Create(fileStream))) {
                    return true;
                }
            }

            return false;
        }
    }
}
