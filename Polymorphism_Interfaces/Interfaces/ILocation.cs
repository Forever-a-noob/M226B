using Polymorphism_Interfaces.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces
{
    interface ILocation : IManageableEntity, IStatisticsEntity
    {
        public string Name { get; set; }

        public List<Vehicle> GetAvailabaleVehicles()
        {
            return new List<Vehicle>();
        }

        public List<SalesManager> GetFreeSalesManagers()
        {
            return new List<SalesManager>();
        }

        public void Visit()
        {

        }
    }
}
