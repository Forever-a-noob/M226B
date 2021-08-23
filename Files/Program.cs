using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("Started Programm.");

            Person person = new Person
            {
                BirthDate = DateTime.Now,
                Name = "kfajköljf"
            };

            BinFile.Write(person, @"person.bin");
            Person personFromBin = (Person) BinFile.Read(@"person.bin");

            Console.WriteLine(personFromBin.Name);
            Console.WriteLine(personFromBin.BirthDate);

            JsonFile.Write(person, @"person.json");
            Person personFromJson = JsonFile.Read(@"person.json");
            //Person personPerson = (Person)personFromJson;

            Console.WriteLine(personFromJson.Name);
            Console.WriteLine(personFromJson.BirthDate);


            Logger.Log("Stopped Programm.");
        }
    }
}
