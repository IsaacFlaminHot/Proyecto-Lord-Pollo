using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Campis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Lord Pollo.");

            Console.WriteLine("Versión Prueba y TEST antes de pasar al form");

            int x, y;

            Console.WriteLine("Ingresa un numero");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un numero");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(x + y);
            Console.ReadKey();
            Console.Clear();

            


        }
    }
}
