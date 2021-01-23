using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileHandler.XmlHandlers {
    public static class XmlHandler {
        public static Task<T> DeserializeXml<T>(string filePath) {
            if (string.IsNullOrEmpty(filePath)) {
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or empty", nameof(filePath));
            }
            return Task.Run(() => {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                string xmlPath = Path.GetFullPath(filePath);
                using (FileStream fileStream = new FileStream(xmlPath, FileMode.Open)) {
                    return (T)serializer.Deserialize(fileStream);
                }
            });
        }
    }
}
