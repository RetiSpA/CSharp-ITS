using System;

namespace Lezione2.D05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** Istruzioni If ***");
            DemoClass.WhatKindOfCharIs();

            Console.WriteLine("\n*** Istruzioni Switch ***");
            DateTime dt = DateTime.Now;
            DemoClass.GetThisMonth(dt);

            Console.ReadLine();
        }
    }
}
