using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;
            bool validacion;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                validacion = Cuadrado.potenciaCuadrado(numero, out cuadrado);
                Cubo.potenciaCubo(numero, out cubo);
                if (validacion)
                {
                    Console.WriteLine("El cuadrado es {0}", cuadrado);
                    Console.WriteLine("El cubo es {0}", cubo);
                }
                else
                {
                    Console.WriteLine("ERROR! Reingrese un numero mayor a cero");
                }
            } while (!validacion);
            Console.ReadKey();
        }
    }
}
