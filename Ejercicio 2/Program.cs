using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad;
            Console.WriteLine("Ingrese la cantidad de numeros para la sucesion");
            Cantidad = int.Parse(Console.ReadLine());
            int[] Sucesion = new int[Cantidad];
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("ingrese el {0} numero de la sucesion", i + 1);
                Sucesion[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(Sucesion);
            Console.WriteLine("\nSucesion invertida\n");
            for (int j = 0; j < Cantidad; j++)
            {
                Console.WriteLine("{0}", Sucesion[j]);
            }
            Console.ReadKey();
        }
    }

}
