using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hälsningsfras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mata in Förnamn
            //Mata in Efternamn
            //Svara användaren Hej Förnamn Efternamn!

            Console.WriteLine("Hej, vad är ditt förnamn?");
            string namn1 = Console.ReadLine();

            Console.WriteLine("Ok, vad är ditt efternamn?");
            string namn2 = Console.ReadLine();

            Console.WriteLine($"Hej {namn1} {namn2}, det var ett fint namn!");
            Console.Beep();
            Console.ReadKey();
            

        }
    }
}
