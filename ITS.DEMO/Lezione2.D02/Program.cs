using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione2.D02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing
            Console.WriteLine("\n*** Boxing ***");
            DemoClass.TestBoxing();

            Console.WriteLine("\n*** Unboxing ***");
            // Unboxing
            DemoClass.TestUnboxing();

            Console.ReadLine();
        }
    }
}
