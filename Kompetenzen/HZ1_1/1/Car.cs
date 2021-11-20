using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ1_1._1
{
    class Car : Vehicle
    {
        public bool HasRoofBox { get; set; }
        public int numberOfDoors { get; set; }

        public void AddRoofBox()
        {
            HasRoofBox = true;
        }

        public void RemoveRoofBox()
        {
            HasRoofBox = false;
        }
    }
}
