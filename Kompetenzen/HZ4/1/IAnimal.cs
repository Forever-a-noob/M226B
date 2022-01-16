using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ4._1
{
    interface IAnimal
    {
        public int NumberOfLegs { get; set; }

        public void Eat();
    }
}
