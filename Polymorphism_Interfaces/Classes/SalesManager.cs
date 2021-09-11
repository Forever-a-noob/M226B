using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    class SalesManager : Employee
    {
        private Customer currentCustomer;

        public Location SalesArea { get; set; }

        public SalesManager()
        {

        }

        public bool IsFree()
        {
            return false;
        }

        public void SetCustomer()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
