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
            Console.Title = "Ejercicio nro 4";
            Console.ForegroundColor = ConsoleColor.Red;
            long i = 2, j;
            int contador = 0;
            long sumador = 0;
            Console.WriteLine("Los primeros 4 numeros perfectos son: ");
            do
            {
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)  
                    {
                        sumador += j;
                    }
                }

                if (sumador == i)
                {
                    contador++;
                    Console.WriteLine("{0}", i);
                }
                i++;
                sumador = 0;
            }while (contador != 4);
            Console.ReadKey();
        }
    }
}
