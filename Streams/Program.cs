using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"ByteArray.bin";

            byte[] byteArrayWrite = { 200, 201, 202, 203, 204, 205, 206, 207 };
            byte[] byteArrayRead = new byte[byteArrayWrite.Length];

            FileStream fs = new FileStream(filename, FileMode.Create);

            fs.Write(byteArrayWrite, 0, byteArrayWrite.Length);

            fs.Position = 0;
            fs.Read(byteArrayRead, 0, byteArrayRead.Length);

            for (int count = 0; count < byteArrayRead.Length; count++)
            {
                Console.Write(byteArrayRead[count] + ", ");
            }

            fs.Close();
            File.Delete(filename);
        }
    }
}
