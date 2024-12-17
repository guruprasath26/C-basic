using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bus obj = new Bus(6);
            //obj.BusDetails();

            //SimiBus obj1 = new SimiBus(8);
            //obj1.BusDetails();

            //Bus obj2= new SimiBus(10);
            //obj2.BusDetails();

            SimiBus obj1=new SimiBus(4);
            obj1.BusDetails();
            obj1.BusCapacity();






            //Calculator calculator = new Calculator();
            //calculator.Add(10, 20);
            //calculator.Add(10, 20,30);
            //calculator.Subraction(20, 10);
        }
    }
}
