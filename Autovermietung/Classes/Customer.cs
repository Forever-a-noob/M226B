using Autovermietung.Interfaces;
using Autovermietung.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermietung.Classes
{
    class Customer : IPerson
    {
        public Employee ConsultingEmployee { get; set; }
        public Store CurrentStore { get; set; }
        public VehicleTypeEnum SelectedVehicleType { get; set; }
        public int RentalDuration { get; set; }

        private List<Vehicle> vehicleList;

        public void EnterStore(Store store)
        {
            CurrentStore = store;
        }

        public bool ChooseEmployee(Employee employee)
        {
            if (employee.IsAvailable)
            {
                ConsultingEmployee = employee;
                return true;
            }
            return false;
        }

        public void ChooseVehicleType(VehicleTypeEnum vehicleType)
        {
            SelectedVehicleType = vehicleType;
            vehicleList = ConsultingEmployee.GetAvailableVehiclesByType(vehicleType);
        }

        public void ChooseVehicle()
        {

        }
    }
}
