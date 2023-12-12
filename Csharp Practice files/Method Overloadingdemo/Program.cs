using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--> the concept of method overloading comes under the polymorphism  of OOP
//--> Polymorphism is a mechanism of changing the behaviour based on the inputs.

// two or more methords having same method names but differnt parameters is called method overloading.

namespace Method_Overloadingdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition( 5 , 3);
        }

        public static void Addition(int num1 , int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public static void Addition(int num1, ref int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        public static void Addition(float num1, float num2)
        {
            float sum = num1 + num2;
            Console.WriteLine(sum);
        }
    // differ in return type does not form method overloading

        /*
        public static int Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
            return sum;
        }
        */
    }
}
