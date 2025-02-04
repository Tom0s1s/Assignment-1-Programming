using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1_simpelkalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Simpel kalylator med + * /
            //Vad användaren får göra
            //kalkylera 
            //Visa resultat i + * /

            double tal1 = 0;
            double tal2 = 0;
            
       
           Console.WriteLine("Vanligen mata in tal 1:");
           tal1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Vänligen mata in tal 2:");
           tal2 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine($"Summan av {tal1} + {tal2} blir: {tal1 + tal2}");
          Console.WriteLine($"Produkten av {tal1} * {tal2} blir: {tal1 * tal2}");
          Console.WriteLine($"Divisionen av {tal1} / {tal2} blir: {tal1 / tal2}");


        }
    }
}
