using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            string binario;
            do
            {
                Console.WriteLine("Ingrese un numero mayor que cero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    Console.WriteLine("Error! Reintente ingresando un numero positivo");
                }
                else
                {
                   binario = Conversor.DecimalBinario(numero);
                    Console.WriteLine("El numero en binario es {0}", binario);
                }
                
            } while (numero < 0);
            Console.ReadKey();
        }
    }
}
