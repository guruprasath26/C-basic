using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class SimiSchoolBus : SimiBus
    {
        public SimiSchoolBus(int wheel) :base(wheel)
            {

        }
        public override void BusDetails()
        {
            Console.WriteLine($"this simi-school bus have {Wheel} wheels");

        }
    }
}
