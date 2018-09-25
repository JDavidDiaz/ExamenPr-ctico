using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
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
            Console.WriteLine("El valor maximo de la sucesion es {0}\nEl valor minimo de la sucesion {1}", Sucesion.Max(), Sucesion.Min());
            Console.ReadKey();
        }
    }

}
