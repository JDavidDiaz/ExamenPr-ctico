using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad;
            Console.WriteLine("Ingrese la cantidad de palabras para la sucesion");
            Cantidad = int.Parse(Console.ReadLine());
            string[] Sucesion = new string[Cantidad];
            for (int i = 0; i < Sucesion.Length; i++)
            {
                Console.WriteLine("ingrese la {0} palabra", i + 1);
                Sucesion[i] = (Console.ReadLine());
            }    
            for (int j = 0; j < Sucesion.Length; j++)
            {
                if (j >= 1)
                {
                    if(Sucesion[j].Length > Sucesion[j - 1].Length)
                    {
                        Console.WriteLine("El primer elemento que es mayor a su predecesor es el elemento: {0}", j + 1);
                        j = Sucesion.Length;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
