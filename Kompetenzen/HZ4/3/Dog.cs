using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ4._3
{
    class Dog
    {
        public Person Owner { get; set; }
        public bool IsHurt { get; set; }

        public void BiteOwner()
        {
            Owner.GetBitten();
        }

        public bool HasBittenOwner()
        {
            if (Owner.HasBeenBitten)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
