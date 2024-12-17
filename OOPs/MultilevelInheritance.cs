using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class MultilevelInheritance:Inheritance1
    {
        public MultilevelInheritance(int employeeid, string employeeName, string address, double salary, int companyId, string companyName, string location) : base(employeeid, employeeName, address, salary, companyId, companyName, location)
        { 
        }
    }
}
