using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Loops
{
    internal class Array
    {
        static void Main(string[] args)
        {
            // array----------------------------------------------

            //int[] num = new int[5];
            //num[0] = 1;
            //num[1] = 2;
            //num[2] = 3;
            //num[3] = 4;
            //num[4] = 5;

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            int[] sales = new int[3];
            String[] months = { "jan", "feb", "mar" };
            for (int i = 0; i < months.Length; i++)
            {
                Console.Write($"Enter the sales for {months[i]}:");
                sales[i] = int.Parse(Console.ReadLine());

            }
            foreach (int x in sales)
            {
                Console.WriteLine(x);
            }
            //System.Array.Sort(sales);
            //foreach (int x in sales)
            //{
            //    Console.WriteLine(x);
            //}
            for (int i = 0; i < sales.Length; i++)
            {
                for (int j = i + 1; j < sales.Length; j++)
                {
                    {
                        if (sales[i] > sales[j])
                        {
                            int tmp = sales[i];
                            sales[i] = sales[j];
                            sales[j] = tmp;
                        }

                    }
                }
                foreach (int x in sales)
                {
                    Console.WriteLine(x);
                }
            }

            }
        }
    }







                //int[] num = new int[6];
                //num[0] = 1;
                //num[1] = 2;
                //num[4] = 3;
                //Console.WriteLine("Length" + " " + num.Length);
                //Console.WriteLine("Index" + " " + num[5]);
                //for (int i = 0; i < num.Length; i++)
                //{
                //    Console.WriteLine(num[i]);

                //}

                //foreach (int i in num)
                //{
                //    Console.WriteLine(i);
                //}



                //int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                //foreach (int i in a)
                //{
                //    Console.WriteLine(i);
                //}



                // arraylist----------------------non -generic collection -limited to any type of object-------------------------------------

                //ArrayList data = new  ArrayList();
                //data.Add(1);
                //data.Add(2);
                //data.Add(3);
                //data.Add(4);
                //data.Add(5);
                //data.Add("guru");
                //data.Add(2.5f);
                //data.Add(true);
                //foreach (var i in data)
                //{
                //    Console.WriteLine(i);
                //}
                //data.Remove(5);
                //foreach (var i in data)
                //{
                //    Console.WriteLine(i);
                //}


                //list--------------------------------generic collection -limited to one type of object
                //List<int> list = new List<int>();
                //list.Add(10);
                //list.Add(20);
                //list.Add(30);
                //list.Add(40);
                //list.Add(50);
                //list.Add(60);
                //for (int i = 0; i < list.Count; i++)
                //{
                //    Console.WriteLine(list[i]);
                //}

                ////remove
                //list.Remove(60);
                //foreach (int i in list)
                //{
                //    Console.WriteLine(i);
                //}

                //remove by indexing
                //list.RemoveAt(1);
                //Console.WriteLine("Remove by index");
                //foreach (int i in list)
                //{

                //        Console.WriteLine(i);
                //}

                ////Hashtable--------------------non - generic collection -limited to any type of object----------
                //Hashtable a = new Hashtable();
                //a.Add(1, "Guru");
                //a.Add(2, "Prasath");
                //a.Add(3, "CEO");
                //a.Add(4, 100); 
                //a.Add("A", 1000);
                //a.Add(5,null);







                //Console.WriteLine(a[3]);
                //Console.WriteLine(a["A"]);
                //Console.WriteLine(a[7]);

                //Console.WriteLine("-------------Dictionarytype");
                //foreach(DictionaryEntry i in a)
                //{
                //    Console.WriteLine(i);
                //}
                //Console.WriteLine("------------Key");
                //foreach (DictionaryEntry i in a)
                //{
                //    Console.WriteLine(i.Key);
                //}
                //Console.WriteLine("-------------------Value");
                //foreach (DictionaryEntry i in a)
                //{
                //    Console.WriteLine(i.Value);
                //}

                // Remove
                //a.Remove(2);

                //foreach (DictionaryEntry i in a)
                //{
                //    Console.WriteLine($"{i.Key} : {i.Value}");
                //}


                // Dictionary------------------generic collection -limited to one type of object--- Keys Duplicate is not allowed--------------------------------------------
                //Dictionary<int, string> a = new Dictionary<int, string>();
                //a.Add(1, "guru");
                //a.Add(2, "prasath");
                //a.Add(3, "CEO");
                //foreach (KeyValuePair<int,string> e in a)
                //{
                //    Console.WriteLine($"{e.Key}:{e.Value}");
                //}

                //for (int i = 0; i < a.Count; i++)
                //{
                //    Console.WriteLine($"{a.Keys.ElementAt(i)}:{a.Values.ElementAt(i)}");
                //}

                //Remove-----------------------------------------
                //a.Remove(2);
                //for (int i = 0; i < a.Count; i++)
                //{
                //    Console.WriteLine($"{a.Keys.ElementAt(i)}:{a.Values.ElementAt(i)}");
                //}



                //stack------------generic collection -limited to one type of object--


            

        //private static void Sort(int[] sales)
        //{
        //    throw new NotImplementedException();
        //}
