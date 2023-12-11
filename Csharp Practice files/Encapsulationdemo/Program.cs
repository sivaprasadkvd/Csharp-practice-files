using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
