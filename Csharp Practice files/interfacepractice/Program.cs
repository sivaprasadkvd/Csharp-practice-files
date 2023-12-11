using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacepractice
{

    interface Itestinterface1
    {
        void add(int a, int b);
    }

    interface Itestinterface2 : Itestinterface1
    {
        void sub(int a, int b);

    }
    class ImplementationClass : Itestinterface2
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)             //void Itestinterface2.sub(int a, int b)
        {
            Console.WriteLine(a - b);

        }

        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            obj.add(1, 2);
            obj.sub(8, 3);
        }
    }
}
