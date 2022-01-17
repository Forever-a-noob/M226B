using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Grow();
            cat.Grow();

            Console.WriteLine($"The Dog is {dog.Size} big.");
            Console.WriteLine($"But the Cat is only {cat.Size} big.");
        }
    }
}
