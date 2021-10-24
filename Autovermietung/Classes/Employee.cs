using Autovermietung.Interfaces;
using Autovermietung.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermietung.Classes
{
    class Employee : IPerson
    {
        public bool IsAvailable { get; set; }

        public List<Vehicle> GetAvailableVehiclesByType(VehicleTypeEnum)
        {
            List<Vehicle> availableVehicles = new List<Vehicle>();

            Vehicle

            return availableVehicles;
        }
    }
}
