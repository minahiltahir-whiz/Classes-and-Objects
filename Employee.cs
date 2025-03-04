using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Employee     
    {
        //Attributes/States/Varaible
        public int Employee_ID;
        public string Name;
        public string Department;
        public double Salary;

        //Constructor
        public Employee(int E_id, string N, string D, double S)
        {
            Employee_ID = E_id;
            Name = N;
            Department = D;
            Salary = S;

        }

        //Behaviours/Methods
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("         Employee Details are as : ");
            Console.WriteLine($"Employee ID: {Employee_ID}.");
            Console.WriteLine($"-->Name: {Name}.");
            Console.WriteLine($"-->Department: {Department}.");
            Console.WriteLine($"-->Salary: ${Salary}.");

        }

        public void IncreaseSalary(double Amount)
        {
            if (Amount < 0)
            {
                Console.WriteLine("Invalid salary increase amount!");
                return;
            }
            else
            {
                Salary = Salary + Amount;
            }
        }

    }
}
