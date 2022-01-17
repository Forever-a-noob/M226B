using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ3._3
{
    public class ImplementIDogNews : IDogNews
    {
        public event EventHandler handler;

        public void PublishDogNews()
        {
            OnInformed(new EventArgs());
        }

        private void OnInformed(EventArgs eventArgs)
        {
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }
    }
}
