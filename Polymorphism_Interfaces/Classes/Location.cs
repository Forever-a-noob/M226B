using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    class Location : BaseModel, ILocation
    {
        private Person currentVisitor;

        public List<object> Children { get; set; }
        public List<Employee> Employees { get; set; }
        public string Name { get; set; }
        public object Parent { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public Location()
        {

        }

        public void AddChild()
        {
        }

        public List<Car> AvailableCars()
        {
            return new List<Car>();
        }

        public List<Vehicle> GetAvailableVehicles()
        {
            return new List<Vehicle>();
        }

        public List<SalesManager> GetFreeSalesManagers()
        {
            return new List<SalesManager>();
        }

        public void PrintStatistics()
        {
        }

        public void SetParent()
        {
        }

        public void Visit()
        {
        }
    }
}
