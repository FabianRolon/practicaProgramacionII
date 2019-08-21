using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            string variable;
            int res;
            int max = int.MinValue;
            int min = int.MaxValue;
            int i;
            int sumaTotal = 0;
            float promedio;
            int contador = 0;

            for(i= 0;i< 4 ;i++ )
            {
                Console.Write("Ingrese un numero, para terminar ingrese 0: ");
                variable = Console.ReadLine();
                if (int.TryParse(variable, out res))
                {
                        
                    if (res > max)
                        max = res;

                    if (res < min)
                        min = res;

                    sumaTotal += res;
                    contador++;
                }
            }

            promedio = (float)sumaTotal / contador;
            Console.WriteLine("El promedio es : {0}", promedio);
            Console.WriteLine("El maximo es : {0}", max);
            Console.WriteLine("El minimo es : {0}", min);

            Console.ReadKey();

        }
    }
}
