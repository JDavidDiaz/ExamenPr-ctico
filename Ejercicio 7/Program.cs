using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Random = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Random[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("Numeros aleatorios");
            for (int j = 0; j < 100; j++)
            {
                Console.WriteLine(Random[j]);
            }
            Array.Sort(Random);
            Console.WriteLine("\nNumeros ordenados de menor a mayor");
            for (int k = 0; k < 100; k++)
            {
                Console.WriteLine(Random[k]);
            }           
            Console.ReadKey();
        }
    }
}
