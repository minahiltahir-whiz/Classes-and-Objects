using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("     Employee Management System     ");
            Employee employee_1 = new Employee(0101, "Ali Ahmed", "IT Department", 70000);
            Employee employee_2 = new Employee(0102, "Muzamil Sohail", "Buisness Department", 52000);

            //Employee Details
            employee_1.DisplayEmployeeDetails();
            employee_2.DisplayEmployeeDetails();

            //After Icreasing Salary
            employee_1.IncreaseSalary(1500);
            employee_2.IncreaseSalary(3500);

            //Details of Employee After Salary increase.
            Console.WriteLine($"\n Details after Incresing Salary.");

            employee_1.DisplayEmployeeDetails();
            employee_2.DisplayEmployeeDetails();

            Console.ReadLine();
        }
    }
}
