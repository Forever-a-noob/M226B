using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ4._3
{
    class Person
    {
        public bool IsHurt { get; set; }

        public void GetBitten()
        {
            IsHurt = true;
        }

        public bool HasBeenBitten()
        {
            return IsHurt;
        }
    }
}
