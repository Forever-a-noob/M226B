using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ1_1._3
{
    class Dog : Animal
    {
        public DogBowl FavouriteBowl { get; set; }

        public Dog(Animal parent, string name, DogBowl favouriteBowl) : base(parent, name)
        {
            FavouriteBowl = favouriteBowl;
        }
    }
}
