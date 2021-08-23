using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Files
{
    class JsonFile
    {
        public static void Write(object content, string path)
        {
            string json = JsonSerializer.Serialize(content);
            File.WriteAllText(path, json);
            Logger.Log("Store object as Json.");
        }

        public static Person Read(string path)
        {
            StreamReader sr = new StreamReader("person.json");

            string jsonString = sr.ReadToEnd();

            Person jsonObject = JsonSerializer.Deserialize<Person>(jsonString);
            Logger.Log("Retrieve Json object.");

            return jsonObject;
        }
    }
}
