using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numero;
            int sumador = 0;
            int max = 0;
            int min = 0;
            double promedio;

            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese 10 numeros entre -100 y 100: ");
                do
                {
                    numero = int.Parse(Console.ReadLine());
                    
                    if(!Validacion.Validar(numero, -100, 100))
                        Console.WriteLine("ERROR! Reingrese el numero respetando el rango indicado: ");
                } while (!Validacion.Validar(numero, -100, 100));
                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                if (numero > max)
                {
                    max = numero;
                }
                else
                {
                    if (numero < min)
                    {
                        min = numero;
                    }
                }
                sumador += numero;
            }
            promedio = (double)sumador / 10;
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("El maximo es {0}", max);
            Console.WriteLine("El minimo es {0}", min);
            Console.ReadKey();
        }
    }
}
