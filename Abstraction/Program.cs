using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction

{
class Program
{
    static void Main(string[] args)
    {
        Employee obj1= new Employee(1,"Max","boss","Google", "Google");
        obj1.EmployeeSalaryDetails();
        obj1.CompanyDetails();
        }
}
}