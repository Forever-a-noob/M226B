using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    abstract class Employee : Person
    {
        public Location Location { get; set; }
        
        public Employee()
        {

        }
    }
}
