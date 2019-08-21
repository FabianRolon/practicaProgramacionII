using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro 3";
            string variable;
            int res;
            int i, j;
            //int modulo;
            int contador = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                variable = Console.ReadLine();
                if (int.TryParse(variable, out res))
                {
                    if (res < 0)
                    {
                        Console.WriteLine("ERROR! Reingresar numero");
                    }
                }
            } while (res < 0);

            for(i = 2; i < res; i++)
            {
                contador = 0;
                for(j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        contador++;                               
                }
                if (contador == 1)
                    Console.WriteLine("{0}", i);
            }
            Console.ReadKey();
        }
    }
}
