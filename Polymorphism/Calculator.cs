using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Calculator
    {
    public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of two number: {x + y}");
        }
        public void Add(int x,int y,int z)
        { 
            Console.WriteLine($"Addition of three numbers : {x+y+z}"); 
        }
        public void Subraction(int x, int y)
        {
            Console.WriteLine($"Subraction of two number: {x - y}");
        }
    }
}
