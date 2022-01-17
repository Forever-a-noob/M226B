using Kompetenzen.HZ4._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ4._3
{
    class Person
    {
        public IAnimal Pet{ get; set; }
        public bool IsHappy 
        { 
            get 
            { 
                if (Pet.IsAlive())
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }
    }
}
