using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Sucesion = new int[3];
            Console.WriteLine("Ingresa 3 numeros");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nnumero {0}:  ", i + 1);
                Sucesion[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEl elemento menor es {0}", Sucesion.Min());
            Console.ReadKey();
        }
    }

}
