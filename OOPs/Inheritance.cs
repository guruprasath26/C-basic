using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Inheritance
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }

    

    public Inheritance(int companyid, string companyname,string location)
        {
            CompanyId = companyid;
            CompanyName = companyname;
            Location = location;
        }


        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"Id:{CompanyId} and Name:{CompanyName} and Location:{Location}");
        }
        
    public void DisplayData()
        {
            Console.WriteLine($"Id:{CompanyId} and Name:{CompanyName}");
        }
    
    }
}
