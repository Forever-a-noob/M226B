using Kompetenzen.HZ4._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ4._3
{
    class Dog : IAnimal
    {
        public bool IsHurt { get; set; }

        public bool IsAlive()
        {
            if (!IsHurt)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
