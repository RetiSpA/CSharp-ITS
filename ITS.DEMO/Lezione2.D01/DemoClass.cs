using System;

namespace Lezione2.D01
{
    public static class DemoClass
    {
        /// <summary>
        /// Metodo che mostra come funziona il passaggio per tipo
        /// </summary>
        public static void TestValueType()
        {

            Int32 a = 42;
            Int32 b = a;

            Console.WriteLine("*** Esempio Value Type ***");
            Console.WriteLine($"Controllo delle variabili inserite: \r\n - a = {a} \r\n - b = {b} \r");

            Console.WriteLine("\nAssegnazione un valore alla variabile b = 0");
            b = 0;

            Console.WriteLine($"\nControllo delle variabili inserite: \r\n - a = {a} \r\n - b = {b} \r");

        }

        /// <summary>
        /// Metodo che mostra come funziona il passaggio per referenza
        /// </summary>
        public static void TestReferenceType()
        {
            Console.WriteLine("\r\n\n*** Esempio Reference Type ***");

            MyReferenceTypeA myRefA = new MyReferenceTypeA();
            myRefA.value = 42;

            MyReferenceTypeA myRefB = myRefA;

            Console.WriteLine($"Controllo variabili inserite: \r\n - myRefA.value = {myRefA.value} \r\n - myRefB.value = {myRefB.value} \r\n");

            Console.WriteLine("\nAssegnazione myRefB.value = 0");
            myRefB.value = 0;

            Console.WriteLine($"\nControllo variabili inserite: \r\n - myRefA.value = {myRefA.value} \r\n - myRefB.value = {myRefB.value} \r\n");

        }
    }

    public class MyReferenceTypeA
    {
        public Int32 value;
    }
}
