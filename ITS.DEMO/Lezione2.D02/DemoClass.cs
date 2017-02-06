using System;

namespace Lezione2.D02
{
    public static class DemoClass
    {
        /// <summary>
        /// Conversione di un dato direttamente
        /// </summary>
        public static void TestBoxing()
        {
            Byte myByte = 166;
            Int32 myInt = myByte;

            Console.WriteLine($"Controllo delle variabili inserite: \r\n - myByte = {myByte} \r\n - myInt = {myInt} \r");

        }

        /// <summary>
        /// Conversione di un dato tramite cast esplicito
        /// </summary>
        public static void TestUnboxing()
        {
            Double myDouble = 58.589;
            Int16 myInt = (Int16)myDouble;

            Console.WriteLine($"Controllo delle variabili inserite: \r\n - myDouble = {myDouble} \r\n - myInt = {myInt} \r");



            DateTime now = new DateTime();

            String clock = (now.Hour > 17) ? " evening." : " day.";

            String greeting = String.Concat("Good ", clock);


        }
    }
}
