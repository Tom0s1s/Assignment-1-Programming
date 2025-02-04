using System;

namespace prog1_kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kalkylator med + * /
            // Vad användaren får göra
            // Vad användaren INTE får göra
            // Kalkylera
            // Visa resultat i + * /
            // Kör om programmet utan att stänga och öppna

            do
            {
                double tal1 = 0;
                double tal2 = 0;

                Console.WriteLine("Simpel Kalkylator");

                while (true)
                {
                    Console.WriteLine("Vanligen mata in tal 1:");
                    string mata = Console.ReadLine();
                    if (double.TryParse(mata, out tal1))
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Ange ett numeriskt värde!");
                    }
                }

              
                while (true)
                {
                    Console.WriteLine("Vanligen mata in tal 2:");
                    string mata = Console.ReadLine();
                    if (double.TryParse(mata, out tal2))
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Ange ett numeriskt värde!");
                    }
                }

                
                double summan = tal1 + tal2;
                double produkten = tal1 * tal2;

                Console.WriteLine($"Summan av {tal1} + {tal2} blir: {summan}");
                Console.WriteLine($"Produkten av {tal1} * {tal2} blir: {produkten}");

                if (tal2 != 0)
                {
                    double divisionen = tal1 / tal2;
                    Console.WriteLine($"Divisionen av {tal1} / {tal2} blir: {divisionen}");
                }
                else
                {
                    Console.WriteLine("Division med 0 går inte!");
                }

               
                Console.WriteLine("Vill du räkna igen? (Y/N):");
                string svar = Console.ReadLine().ToUpper();

                if (svar != "Y")
                {
                    break; 
                }

            } while (true);

            Console.WriteLine("Programmet avslutas. Hejdå!");
        }
    }
}
