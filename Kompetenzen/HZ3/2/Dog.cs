using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ3._2
{
    class Dog : Animal
    {
        public override void Grow()
        {
            Size += 2;
        }
    }
}
