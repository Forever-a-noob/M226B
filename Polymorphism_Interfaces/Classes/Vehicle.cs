using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    abstract class Vehicle : BaseModel, IBookableEntity, IManageableEntity
    {
        public string Brand { get; set; }
        public List<object> Children { get; set; }
        public Location Location { get; set; }
        public string Name { get; set; }
        public object Parent { get; set; }
        public override string Text { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public void AddChild()
        {
        }

        public void Drive() 
        { 
        }

        public bool IsAvailable()
        {
            return false;
        }

        public void Reserve()
        {
        }

        public void SetParent()
        {
        }



    }
}
