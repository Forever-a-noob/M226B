using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ1_1._2
{
    class Car
    {
        public int numberOfDoors { get; set; }
        public Tire Tire { get; set; }
           
        public void changeTire()
        {
            Tire = new Tire();
        }
    }
}
