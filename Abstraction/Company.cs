using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Abstract class
namespace Abstraction
{
    public abstract class Company
    {
        public  string Name { get; set; }
        public  string Description { get; set; }

        public Company(string name, string description)
        {
            Name = name;
            Description = description;
}
        public abstract void CompanyDetails();
        
    }
}
