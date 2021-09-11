using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    class CarType : BaseModel, ICarType
    {
        public CarType GetCarType { get; set; }
        public String Name { get; set; }
    }
}
