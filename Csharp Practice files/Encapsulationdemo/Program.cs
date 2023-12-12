using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Encapsulation is achieved through by declaring class variables as private ..
//And given access to those private variables only by public set and get methods to read and modify.

namespace Encapsulationdemo
{
    public class Employee
    {
        private int salary = 30000;
        public int getsal()
        {
            return salary;
        }
        public void setsal(int x)
        {
            this.salary = x;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.setsal(50000);

            int e1sal = e1.getsal();
            Console.WriteLine(e1sal);
        }
    }

    
}
