using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[19];
            Random numeroAleatorios = new Random();

            for(int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = numeroAleatorios.Next(-1000, 1000);
                
            }
            
            for (int j = 0; j < arrayNumeros.Length; j++)
            {
                Console.WriteLine("{0}", arrayNumeros[j]);

            }
            Array.Sort(arrayNumeros);
            for (int k = 0; k < arrayNumeros.Length; k++)
            {
                if(arrayNumeros[k] > 0)
                    Console.WriteLine("{0}", arrayNumeros[k]);

            }

            Array.Reverse(arrayNumeros);

            Console.ReadKey();

        }
    }
}
