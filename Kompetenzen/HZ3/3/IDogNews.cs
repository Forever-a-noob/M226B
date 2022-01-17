using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ3._3
{
    public interface IDogNews
    {
        event EventHandler handler;
        void PublishDogNews();
    }
}
