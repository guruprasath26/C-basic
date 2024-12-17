using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Loop
    {
        static void Main(string[] args)
        {

            string name="";
           

            while(name!="end")
            {
                Console.Write("Enter the name");
                name = Console.ReadLine();

            }








            //Russian Multiplication

            //int x, y;
            //Console.Write("Enter value of x=");
            //x=int.Parse(Console.ReadLine());
            //Console.Write("Enter value of y=");
            //y=int.Parse(Console.ReadLine());
            //int a, b;
            //a = x; b=y;
            //int tot = 0;
            //while(x>0)
            //{
            //    if (x % 2 != 0)
            //    {
            //        tot += y;
            //    }
            //    x /= 2;
            //    y*=2; 
            //}
            //Console.WriteLine($"The value of  {a} and {b}is {tot}");





            ////prime number--------------

            //int a, f;
            //Console.Write("Enter the number:");
            //a = int.Parse(Console.ReadLine());
            //int result = 0;
            //f = 1;

            //for (int i = 2; i < a; i++)
            //{
            //    if (a % i == 0) {
            //        result = 1;
            //        break;
            //    }
            //}
            //if (result == 0)
            //{
            //    Console.WriteLine($" {a} is a Prime Number");
            //}
            //else {
            //    Console.WriteLine("it is not prime number");
            //        }




            //Factorial---------------------------

            //int a, f;
            //Console.Write("Enter the number:");
            //a = int.Parse(Console.ReadLine());

            //f = 1;

            //for (int i = 1; i <= a; i++)
            //{
            //    f = f * i;
            //}
            //Console.WriteLine($"Factorial of {a} is {f}");




            // collections-array
            //int[] num = new int[5];
            //num[0] = 1;
            //num[1] = 2;
            //num[2] = 3;
            //num[3] = 4;
            //num[4] = 5;

            //for (int i=0; i<num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}



            //foreach(int i in num)
            //{
            //    Console.WriteLine(i);
            //}



            //int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //foreach (int i in a)
            //{
            //    Console.WriteLine(i);
            //}




            //loop-----------------------------------------------------------------------

            //int n = 0;
            //do {
            //    Console.WriteLine(n);
            //    n++;
            //}
            //while (n < 10) ;




            //int num = 0;
            //while (num < 100)
            //{
            //    Console.WriteLine(num);
            //    num++;
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
