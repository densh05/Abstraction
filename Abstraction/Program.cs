using System;
using System.Threading.Channels;

namespace Abstraction
{
    class ConcretClassA
    {
        public void Operation()
        {
            Console.WriteLine("Concrete class A");
        }
    }

    abstract class AbstractClass : ConcretClassA
    {
        public abstract void Method();
    }

    class ConcretClassB : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Concrete class B");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcretClassB();

            instance.Operation();
            instance.Method();


            
        }
    }
}
