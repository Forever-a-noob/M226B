using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompetenzen.HZ1_1._1
{
    class Truck : Vehicle
    {
        public float PayloadCapacity { get; set; }

        private float payload;
        public float Payload
        {
            get
            {
                return payload;
            }
            set 
            {  
                if (value < 0)
                {
                    payload = 0;
                }
                payload = value;
            } 
        }

        public void LoadTruck(float tonnes)
        {
            Payload += tonnes;
            if (Payload > PayloadCapacity)
            {
                Console.WriteLine("WARNING!! Payload capacity exceded");
            }
        }

        public void UnloadTruck(float tonnes)
        {
            Payload -= tonnes;
        }
    }
}
