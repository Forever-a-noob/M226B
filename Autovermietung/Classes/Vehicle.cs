using Autovermietung.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermietung.Classes
{
    class Vehicle
    {
        public VehicleTypeEnum VehicleType { get; set; }
        public float Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
