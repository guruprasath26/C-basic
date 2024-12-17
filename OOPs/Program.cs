using System;
using System.Collections.Generic;

namespace OOPs
{
    internal class OOPs
    {
        static void Main(string[] args)
        {
            ////Inheritance

            //Inheritance1 obj= new Inheritance1(101,"Guru","TamilNadu",50000,1,"Google","India");
            ////Base class function
            //obj.DisplayCompanyDetails();

            ////Derived class function
            //obj.EmployeeCompanyDetails();
            //obj.EmployeeDetails();
            ////Interface
            //obj.SalaryDetails();

            ////MultilevelInheritance-----------------
            //Console.WriteLine("*************************");
            //MultilevelInheritance obj1 = new MultilevelInheritance(102, "Guru", "NewYork", 50000, 1, "Facebook", "USA");
            ////Inheritance
            //obj1.DisplayCompanyDetails();

            ////Parent Inheritance1
            //obj1.EmployeeCompanyDetails();
            //obj1.EmployeeDetails();
            ////Interface
            //obj1.SalaryDetails();


            Inheritance2 obj2 = new Inheritance2(102, "Guru", 50000, 1, "Facebook", "USA");
            obj2.DisplayCompanyDetails();

            obj2.ExternalEmployeeDetails();


            //-------------------------------------------------


            //List<Company> companies = new List<Company>
            //{
            //    new Company
            //    {
            //        Id = 1,
            //        Name = "Google",
            //        Location = "India"
            //    },
            //    new Company
            //    {
            //        Id = 2,
            //        Name = "YouTube",
            //        Location = "India"
            //    },
            //    new Company
            //    {
            //        Id = 3,
            //        Name = "TikTok",
            //        Location = "India"
            //    },
            //    new Company
            //    {
            //        Id = 4,
            //        Name = "Facebook",
            //        Location = "India"
            //    }
            //};

            //foreach (var company in companies)
            //{
            //    Console.WriteLine($"Id: {company.Id}, Name: {company.Name}, Location: {company.Location}");
            //}
        }
    }

            }











            //// Empty constructor
            //Company obj = new Company
            //{ Id = 4,
            //    Name = "Youtube",
            //    Position = "CEO",
            //};
            //obj.DisplayCompanyDetails();

            //constructor
            //Company obj1 = new Company(1, "Google","CEO");
            //obj1.DisplayCompanyDetails();

            //Company obj2 = new Company(2, "Alphbet","CEO");
            //obj2.DisplayCompanyDetails();

            //-------------method2---------
            //Company obj = new Company();
            //Console.WriteLine(obj.Id);
            //Console.WriteLine(obj.Name);


            //-----------method1--------------------
            // Company obj= new Company();
            // obj.id = 3;
            //// obj.Setter("Guru");
            // Console.WriteLine(obj.id);

            // Console.WriteLine(obj.Getter());

            //Company googleobj = new Company();
            //googleobj.id = 2;
            //googleobj.name = "Alphabet";
            //googleobj.DisplayCompanyDetails();

            //Company obj= new Company();
            //obj.DisplayCompanyDetails();
    //    }
//    }
//}
