using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Inheritance1 : Inheritance, IEmployeeSalary
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        public Inheritance1(int employeeid,string employeeName,string address,double salary,int companyId, string companyName, string location) : base(companyId, companyName, location)
        {

            EmployeeId = employeeid;
            EmployeeName = employeeName;
            Address = address;
            Salary= salary;
        }
        public void EmployeeDetails()
        {
            Console.WriteLine($"Employee Name : {EmployeeName} and Address: {Address}");

        }
        public void EmployeeCompanyDetails()
        {
          Console.WriteLine($"Employee Name: {EmployeeName}  - Company Name: {CompanyName} and Location: {Location}");  
        }

        public void SalaryDetails()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
