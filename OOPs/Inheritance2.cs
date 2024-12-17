using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Inheritance2 : Inheritance
    {
        public int ExternalEmployeeId { get; set; }
        public string ExternalEmployeeName { get; set; }
        public double Salary { get; set; }

        public Inheritance2(int externalEmployeeId, string externalEmployeeName, double salary, int companyId, string companyName, string location) : base(companyId, companyName, location)
        {
            ExternalEmployeeId = externalEmployeeId;
            ExternalEmployeeName = externalEmployeeName;
            Salary = salary;
        }
        public void ExternalEmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {ExternalEmployeeName} and Salary: {Salary}");
}
    }
}
