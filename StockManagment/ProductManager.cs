using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data;

namespace StockManagment
{
    class ProductManager
    {
        public static void ProductAdd(object obj, string name)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(name);
            sr.Serialize(writer, obj);
            writer.Close();
        }
        public static Product ProductRead(string name)
        {

            Product obj = new Product();
            XmlSerializer sr = new XmlSerializer(typeof(Product));
            FileStream reader = new FileStream(name, FileMode.Open, FileAccess.Read, FileShare.Read);
            obj = (Product)sr.Deserialize(reader);
     
            reader.Close();

            return obj;
        }
    }
}
