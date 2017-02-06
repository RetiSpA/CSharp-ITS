using System;


namespace Lezione2.D03
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\n*** Inserire lo zip code dello stato d'interesse (numero intero 0-5)");
            ConsoleKeyInfo userInput = Console.ReadKey();

            // Validare sempre i dati inseriti dall'utente
            if (Char.IsDigit(userInput.KeyChar))
            {
                Int32 zip = Int32.Parse(userInput.KeyChar.ToString());
                Console.WriteLine($"\n\nUser Inserted: {zip}");

                String stateEnumName = Enum.GetName(typeof(DemoClass.States), zip);

                String state = DemoClass.GetEnumDescription(stateEnumName);
                Console.WriteLine($"\nState name: {state}");

                if (stateEnumName.Equals(DemoClass.States.Washington.ToString()))
                {
                    Console.WriteLine($"{state}, formally the District of Columbia and commonly referred to as 'Washington', \n'the District', or simply 'D.C.', is the capital of the United States.");
                }
            }
            Console.ReadLine();
        }
    }
}
