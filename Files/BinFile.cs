using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class BinFile
    {
        public static void Write(object content, string path)
        {
            FileStream fs = File.OpenWrite(path);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, content);
            Logger.Log("Store object in bin file.");

            fs.Close();
        }

        public static object Read(string path)
        {
            FileStream fs = File.OpenRead(path);
            BinaryFormatter formatter = new BinaryFormatter();

            object fileContent = formatter.Deserialize(fs);
            Logger.Log("Retrieve object from bin file.");

            fs.Close();

            return fileContent;
        }
    }
}
