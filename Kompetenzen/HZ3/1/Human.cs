using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ3._1
{
    class Human : Creature
    {
        string profession;

        public Human(string profession)
        {
            this.profession = profession;
        }

        public void KillInsect(Insect insect)
        {
            insect = null;
        }
    }
}
