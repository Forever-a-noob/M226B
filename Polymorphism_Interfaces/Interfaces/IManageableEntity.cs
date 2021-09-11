using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces
{
    interface IManageableEntity
    {
        public List<object> Children { get; set; }
        public object Parent { get; set; }

        public void AddChild(object child)
        {
            Children.Add(child);
        }

        public void SetParent(object parent)
        {
            Parent = parent;
        }
    }
}
