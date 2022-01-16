using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ4._1
{
    class Person
    {
        public IAnimal Animal { get; set; }

        public void getDog()
        {
            Animal = new Dog();
        }
    }
}
