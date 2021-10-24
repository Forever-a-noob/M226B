using Autovermietung.Classes;
using Autovermietung.Enums;
using System;

namespace Autovermietung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup
            Store store = new Store();
            Customer customer = new Customer();
            Employee employee = new Employee();


            //Workflow
            customer.EnterStore(store);
            customer.ConsultingEmployee = employee;
            customer.ChooseVehicleType(VehicleTypeEnum.Truck);
            customer.RequestAvailableVehicles();
        }
    }
}
