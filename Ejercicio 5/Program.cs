using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
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
                Console.WriteLine("ingrese el {0} numero", i + 1);
                Sucesion[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEl primer elemento con mayor valor es: {0}, en la posicion {1}", Sucesion.Max(), Sucesion.ToList().IndexOf(Sucesion.Max()) + 1);
            Console.ReadKey();
        }
    }

}
