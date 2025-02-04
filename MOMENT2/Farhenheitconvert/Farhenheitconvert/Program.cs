using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farhenheitconvert
{
    internal class Program
    {
        static void Main(string[] args)
        {//Mata in Celsius 
         // Konvertera till farenheit
         // visa konverteringen.
         //farenheit = 1,8 *
         //celsius = + 32

        

           
            Console.Write("Mata in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = 1.8 * celsius + 32;

            Console.WriteLine($"{celsius} Celsius blir {fahrenheit} Fahrenheit.");

        }
    }
}
