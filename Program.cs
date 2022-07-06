using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Namespace.namespace1;
//using Namespace.namespace2;
//using A = Namespace.namespace1;
//using B=Namespace.namespace2;



namespace Namespace
{
    namespace namespace1
    {
        public class ClassA
        {
            public static void print()
            {
                Console.WriteLine("I'm ClassA in namespace1");
            }
        }
    }

}
namespace Namespace
{
    namespace namespace2
    {
        public class ClassB
        {
            public static void print()
            {
                Console.WriteLine("I'm ClassB in namespace2");
            }
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
       Namespace.namespace1. ClassA.print();
       Namespace.namespace2.ClassB.print();
        }
    }

