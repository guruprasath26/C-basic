using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Company
    {

        //-------------Empty Constructor-----------------

        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public Company()
        {

        }




        //-------------------Constructor-------------

    
        //public int Id { get; set; } 
        //public string Name { get; set; } 

        //public string Position { get; set; }


        //public Company(int id, string name, string location)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    Position = location;
        //}

        //---------method2-----------------
        //memebers
        //public int Id { get; set; } = 1;
        //public string Name { get; set; } = "Google";

        //public string Position { get; set; } = "CEO";



        //----------------------------method1---------------------------------------------
        // //memebers
        // public int id = 1;
        //private string name = "Google";


        // public string Getter() { 
        //     return name;                                                     
        // }

        // public void Setter(string name)
        // {
        //     this.name = name;

        // }



        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"id:{Id} and Name :{Name} and Postion: {Location}" );
        }
    }
}
