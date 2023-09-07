using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        private static double radius;
        private static double len;
        private static double square;
        static void Main(string[] args)
        { 
        
        radius = double.Parse(Console.ReadLine());
            len = 3.14 *2.0* radius;
            square = 3.14 * Math.Pow(radius,2.0);
            Console.WriteLine("Длина окружности:" + len);
            Console.WriteLine("Площадь окружности:" + square);

        }
    }

}