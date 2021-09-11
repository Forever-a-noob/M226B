using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interfaces.Classes
{
    abstract class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public virtual string Text { get; set; }
    }
}
