using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    class Customer : Person
    {
        public Person Person { get; set; }

        public Customer()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
