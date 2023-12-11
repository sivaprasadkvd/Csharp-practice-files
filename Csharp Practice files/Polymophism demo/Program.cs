using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// polymorphism is a mechanism of changing the behavior based on the inputs given

namespace Polymophism_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee pte = new PartTimeEmployee();
            pte.firstName = "siva";
            pte.lastName = "prasad";
    

            pte.PrintFullName();


        }
    }
    public class Employee
    {
        public string firstName;
        public string lastName;

        public virtual void PrintFullName()
        {
            Console.WriteLine("Your full name is: " + firstName + " " + lastName);
        }
    }

   
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Your full name is: " + firstName + " " + lastName + " child flag");
        }
    }


    
}
