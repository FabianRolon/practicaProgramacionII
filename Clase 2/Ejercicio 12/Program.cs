using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            char respuesta;
            int numero;
            int sumador = 0;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                sumador += numero;
                Console.WriteLine("CONTINUAR? (S/N): ");
                c = char.Parse(Console.ReadLine());

                if (ValidarRespuesta.ValidarS_N(c))
                    respuesta = c;

            } while (c != 'N');
            Console.WriteLine("La suma total es: {0}", sumador);
            Console.ReadKey();
        }
    }
}
