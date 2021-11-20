using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ1_1._1
{
    class Vehicle
    {
        public int Wheels { get; set; }
        public double DistanceDriven { get; set; }
        public int HorsePower { get; set; }

        public void Drive()
        {
            DistanceDriven += 0.1;
        }
    }
}
