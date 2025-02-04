using System;

namespace MOMENT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double tal1 = 0;
                double tal2 = 0;
                double resultat = 0;

                Console.WriteLine("Miniräknare");

                // Läs in första talet
                while (true)
                {
                    Console.Write("Skriv in ett tal: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out tal1))
                    {
                        break; // Avsluta loopen om konverteringen lyckas
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning! Ange ett numeriskt värde.");
                    }
                }

                // Läs in andra talet
                while (true)
                {
                    Console.Write("Skriv in ett till tal: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out tal2))
                    {
                        break; // Avsluta loopen om konverteringen lyckas
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning! Ange ett numeriskt värde.");
                    }
                }

                // Visa alternativ för beräkningar
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("+ : För addition");
                Console.WriteLine("- : För subtraktion");
                Console.WriteLine("* : För multiplikation");
                Console.WriteLine("/ : För division");
                Console.Write("Välj ett räknesätt: ");

                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        resultat = tal1 + tal2;
                        Console.WriteLine($"Ditt resultat blir: {tal1} + {tal2} = {resultat}");
                        break;

                    case "-":
                        resultat = tal1 - tal2;
                        Console.WriteLine($"Ditt resultat blir: {tal1} - {tal2} = {resultat}");
                        break;

                    case "*":
                        resultat = tal1 * tal2;
                        Console.WriteLine($"Ditt resultat blir: {tal1} * {tal2} = {resultat}");
                        break;

                    case "/":
                        if (tal2 == 0)
                        {
                            Console.WriteLine("Fel: Division med 0 är inte tillåten.");
                        }
                        else
                        {
                            resultat = tal1 / tal2;
                            Console.WriteLine($"Ditt resultat blir: {tal1} / {tal2} = {resultat}");
                        }
                        break;

                    default:
                        Console.WriteLine("Det var inte ett giltigt alternativ.");
                        break;
                }

                // Fråga om användaren vill fortsätta
                Console.Write("Vill du fortsätta? (Y = Ja!, N = Nej!): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Hejdå!");
        }
    }
}
