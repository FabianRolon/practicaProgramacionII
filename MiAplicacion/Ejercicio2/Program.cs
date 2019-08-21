using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable;
            int res;
            double cuadrado;
            double cubo;
            Console.Title = "Ejercicio Nro 2";
            do
            {
                Console.Write("Ingrese un numero mayor que cero: ");
                variable = Console.ReadLine();
                if (int.TryParse(variable, out res))
                {
                    if (res < 0)
                    {
                        Console.WriteLine("ERROR! Reingresar numero");
                    }
                }
            } while (res < 0);

            cuadrado = Math.Pow(res, 2);
            cubo = Math.Pow(res, 3);

            Console.WriteLine("El cuadrado es : {0}", cuadrado);
            Console.WriteLine("El cubo es : {0}", cubo);
            Console.ReadKey();
        }
    }
}
