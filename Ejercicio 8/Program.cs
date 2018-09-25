using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int Entero, NumeroInvertido, Comparacion;
            do
            {
                Comparacion = 0;
                NumeroInvertido = 0;
                Entero = 0;
                try
                {

                    Console.WriteLine("Ingrese un numero entero de 5 digitos");
                    Entero = int.Parse(Console.ReadLine());
                    Comparacion = Entero;
                    int tamaño = Entero.ToString().Length;
                    if (tamaño != 5)
                    {
                       throw new Exception("Numero invalido");
                    }       
                }
                catch (Exception e)
                {
               Console.WriteLine(e.Message);
                }
            } while (Entero.ToString().Length != 5);
            while (Entero > 0)
            {
                NumeroInvertido = NumeroInvertido * 10 + (Entero % 10);
                Entero = Entero / 10;
            }
            if (NumeroInvertido == Comparacion)
            {
                Console.WriteLine("El numero ingresado es palíndromo {0}", NumeroInvertido);
            }
            else
            {
                Console.WriteLine("El numero ingresado no es palíindromo: {0}" , NumeroInvertido);
            }
            Console.ReadKey();
        }
    }
}
