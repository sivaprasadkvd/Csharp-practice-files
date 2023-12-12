using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data Abstraction is about hiding unnecessary details and showing only essential information to the user

// Abstraction can also be achieved with interfaces also.


namespace abstractiondemo
{
    class Enduser
    {
        static void main(string[] args)
        {
            Car Innova = new Car();

            Innova.TurnOnCar();
            Innova.TurnOffCar();

        }
    }

    public class Car
    {
        public void TurnOnCar()
        {
            Console.WriteLine("turn on the manual car");
           
        }

        public void TurnOffCar()
        {
            Console.WriteLine("Turn on the manual car");
        }

        private void ChangePistonSpeed()
        {
            Console.WriteLine("ChangePistonSpeed Implementation");  
        }

        private void MoveBreakpads()
        {
            Console.WriteLine("MoveBreakpads Implementation");
        }
    }

}
