using Lezione2.D05;
using System;
using System.Globalization;

namespace Lezione2.D05
{
    public static class DemoClass
    {
        /// <summary>
        /// L'esempio seguente determina se un carattere di 
        /// input è una lettera minuscola, una lettera maiuscola o un numero. 
        /// </summary>
        public static void WhatKindOfCharIs()
        {
            Console.Write("Enter a character: ");
            Char ch = (Char)Console.ReadKey().KeyChar;

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("\nThe character is an uppercase letter.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("\nThe character is a lowercase letter.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("\nThe character is a number.");
            }
            else
            {
                Console.WriteLine("\nThe character is not alphanumeric.");
            }
        }

        /// <summary>
        /// Restituisce il nome del mese corrente sfruttando la il costrutto switch per la selezione
        /// </summary>
        public static void GetThisMonth(DateTime month)
        {
            Console.WriteLine($"La data di oggi è {month}");

            String monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month.Month).ToLower();

            switch (monthName)
            {
                case "gennaio":
                    Console.WriteLine("Il mese selezionato è Gennaio");
                    break;
                case "febbraio":
                    Console.WriteLine("Il mese selezionato è Febbraio");
                    break;
                case "marzo":
                    Console.WriteLine("Il mese selezionato è Marzo");
                    break;
                case "aprile":
                    Console.WriteLine("Il mese selezionato è Aprile");
                    break;
                case "maggio":
                    Console.WriteLine("Il mese selezionato è Maggio");
                    break;
                default:
                    Console.WriteLine
                    ("Il mese selezionato non è stato riconosciuto");
                    break;
            }
        }
    }
}
