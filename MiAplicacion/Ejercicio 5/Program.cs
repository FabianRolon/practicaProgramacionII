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
            Console.Title = "Ejercicio nro 5";
            Console.ForegroundColor = ConsoleColor.Red;
            string variable;
            int aux;
          //  int i, j;
          //  int contador = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                variable = Console.ReadLine();
                if (int.TryParse(variable, out aux))
                {
                    if (aux < 0)
                    {
                        Console.WriteLine("ERROR! Reingresar numero");
                    }
                }
            } while (aux < 0);

            
            Console.ReadKey();
        }
    }
}
