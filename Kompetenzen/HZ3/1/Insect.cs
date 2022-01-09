using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ3._1
{
    class Insect : Creature
    {
        bool isAnnoying;

        public Insect(bool isAnnoying = true)
        {
            this.isAnnoying = isAnnoying;
        }

        public override void Breathe()
        {
            Console.WriteLine("Taking a gentle breath");
        }
    }
}
