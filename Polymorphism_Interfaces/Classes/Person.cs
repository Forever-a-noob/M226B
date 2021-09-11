using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    class Person : BaseModel, IManageableEntity
    {
        private Location location;

        public string Name { get; set; }

        public Person()
        {

        }
        
        public void AddChild()
        {

        }

        public void PrintInfos()
        {

        }

        public void SetParent()
        {

        }

        public override string ToString()
        {
            return "";
        }
    }
}
