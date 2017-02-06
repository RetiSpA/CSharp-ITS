using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione2.D04
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 arg;

            // Passing by value
            arg = 4;
            Console.WriteLine($"\n- Before - Value in Main block: {arg}");
            squareVal(arg);

            // The value of arg in Main is not changed.
            Console.WriteLine($"\n- After - Value in Main block: {arg}"); // Output: 4

            // Passing by reference.
            arg = 4;
            Console.WriteLine($"\n- Before - Value in Main block: {arg}");
            squareRef(ref arg);
            Console.WriteLine($"\n- After - Value in Main block: {arg}");  // Output: 16 

            Console.ReadLine();
        }
        
        // Passing by value
        static void squareVal(Int32 valParameter)
        {
            valParameter *= valParameter;
            Console.WriteLine($"\n *****Value in method (passing by value): {valParameter}"); 
        }

        // Passing by reference
        static void squareRef(ref Int32 refParameter)
        {
            refParameter *= refParameter;
            Console.WriteLine($"\n *****Value in method (passing by reference): {refParameter}");
        }
    }
}
