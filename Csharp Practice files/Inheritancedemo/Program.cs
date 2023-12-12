using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// inheritance is the process of acquiring all the properties and methods of one class into others.
//  syntax:      class B : class A

namespace Inheritancedemo
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine("Your full name is: " + firstName +" "+ lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }
    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
    }


    public class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.firstName = "siva";
            fte.lastName = "prasad";
            fte.YearlySalary = 300000;

            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.firstName = "MAHESH";
            pte.lastName = "babu";
            pte.hourlyRate = 1000;
            pte.PrintFullName();
        }
    }
}
