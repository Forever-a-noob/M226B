using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    class Car : Vehicle
    {
        public CarType Type { get; set; }

        public Car()
        {
        }

        public Car(CarType type)
        {
            Type = type;
        }

        public void CarTypeName()
        {
        }
    }
}
