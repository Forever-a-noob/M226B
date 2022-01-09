using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ1_1._3
{
    class Animal
    {
        public Animal Parent { get; set; }
        public string Name { get; set; }

        public Animal (Animal parent, string name)
        {
            Parent = parent;
        }

        public void giveBirth(String name)
        {
            Animal animal = new Animal(this, name);
        }
    }
}
