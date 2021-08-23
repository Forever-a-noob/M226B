using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Logger
    {
        public static void Log(string message)
        {
            byte[] bytes = Encoding.ASCII.GetBytes($"{message} \n");
            FileStream fs = new FileStream("log.txt", FileMode.Append);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }
    }
}
