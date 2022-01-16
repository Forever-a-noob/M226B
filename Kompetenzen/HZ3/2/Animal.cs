using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ3._2
{
    abstract class Animal
    {
        public int Size { get; set; }
        public abstract void Grow();
    }
}
