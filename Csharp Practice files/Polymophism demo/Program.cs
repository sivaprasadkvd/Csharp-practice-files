using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//method override allows you to invoke child/derived class methords through parent/base class reference during runtime is known as M-over-ridding
// in base class method is declared virtual ,and in derived class we override the same method

//inherited class is required to method overrideing

namespace MethodOverridding_demo
{
    public class BaseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("Baseclass HeLLO");
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void Greetings()
        {
            Console.WriteLine("Derivedclass HeLLO");
        }
    }

    public class Test
    {
        public static void Main()
        {
            BaseClass b = new DerivedClass();

            b.Greetings();
        }
    }

    
}
