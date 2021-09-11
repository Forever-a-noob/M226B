using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    class Truck : Vehicle
    {
        public double LoadingWeight { get; set; }

        public Truck()
        {
        }

        public Truck(float loadingWeight)
        {
            LoadingWeight = loadingWeight;
        }
    }
}
