using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class SimiBus:Bus
    {
        public SimiBus(int wheel) :base(wheel)
        { }

        public new void BusCapacity()
        {
            Console.WriteLine("Capacity:20");
        }


        public  override void BusDetails()
            {
            Console.WriteLine($"this simi-bus have {Wheel} wheels");

            }
       
    }
}
