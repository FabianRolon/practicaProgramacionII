using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            char operacion;

            Console.WriteLine("Ingrese el primer numero: ");
            primerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la operacion (+, -, * o /): ");
            operacion = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            segundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es {0}", Calculadora.Calcular(primerNumero, segundoNumero, operacion));
            Console.ReadKey();

        
        }
    }
}
