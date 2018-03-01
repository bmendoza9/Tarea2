using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Tarea2
{
    class XmlSave
    {
        public static void SaveData(object IClass, string Filename)
        {
            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer((IClass.GetType()));
                writer = new StreamWriter(Filename);
                xmlSerializer.Serialize(writer, IClass);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                    writer = null;
                }
            }
        }
    }
}
