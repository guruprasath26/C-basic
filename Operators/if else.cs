
namespace Condition_statement
{
    internal class if_else
    {
        static void Main(string[] args)
        {
            //int cr, pr,unit, rate, amt;
            //char type;
            //Console.Write("Enter the correct reading:");
            //cr=int.Parse(Console.ReadLine());
            //Console.Write("Enter Previous Reading:");
            //pr=int.Parse(Console.ReadLine());
            //unit=Math.Abs(cr-pr);
            //Console.Write("Enter the connection type:");
            //type=Convert.ToChar(Console.Read());
            //switch (type) 
            //{
            //    case 'D':
            //            rate = 2;
            //        break;
            //    case 'I':
            //        rate = 4; break;
            //    case 'C':
            //        rate = 3;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        rate = 0;
            //        break;

            //}


            //amt = unit * rate;
            //Console.WriteLine($" Amount is ={amt}");












            //string colour=Console.ReadLine();
            //switch(colour.ToLower())
            //{
            //    case "green":
            //        Console.WriteLine("you are selected green colour");
            //        break;

            //    case "red":
            //        Console.WriteLine("you are selected red colour");
            //        break;

            //    case "blue":
            //        Console.WriteLine("you are selected blue colour");
            //        break;

            //     case "white":
            //         Console.WriteLine("you are selected white colour");
            //         break;
            //    default:
            //        Console.WriteLine("Invalid Option");
            //        break;
            //}








            //Console.WriteLine("Enter Your Age");
            //string ageString = Console.ReadLine();
            //int age;
            //bool result=int.TryParse(ageString, out age);
            //Console.WriteLine(result);


            //if (result) {
            //    if (age > 10)
            //    {
            //        if (age >= 18)
            //        {
            //            Console.WriteLine("Permission for Enter in Movie");
            //        }
            //        Console.WriteLine("Enter the Mall");
            //        Console.WriteLine("Permission for Shopping");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Permission Denied");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter the Valid Age");
            //}




            //int a = 10;
            //int b = 200;
            //int c = 30;
            //if ((a > b) && (a > c))
            //{
            //    Console.WriteLine("A greater than B and C");
            //}
            //else if ((a < b) && (c < b))
            //{
            //    Console.WriteLine("B greater than A and C");
            //}
            //else
            //{
            //    Console.WriteLine("C greater than A and B");
            //}





            //if (a > b)
            //{
            //    Console.WriteLine("A greater than B");
            //}
            //else
            //{
            //    Console.WriteLine("B greater than A");
            //}

            //else if
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }


            //if else shorthand
            //int time = 20;
            //string result = (time < 18) ? "Good day." : "Good evening.";
            //Console.WriteLine(result);
        }
    }
}