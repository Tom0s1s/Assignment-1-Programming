using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circlekalk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cirkelmått 
            // Area = PIe * radie^2
            // Omkrets = 2 * Pie * Radie

           

            Console.Write("Räkna Cirkelmått, ange cirkelns radie:");


            double cirkel = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(cirkel, 2);
            double omkrets = 2 * Math.PI * cirkel;

            Console.WriteLine($"Cirkelns radie:{cirkel}");
            Console.WriteLine($"Cirkelns area:{area:F2}");
            Console.WriteLine($"Cirkelns omkrets {omkrets:F2}");



        }
    }
}
