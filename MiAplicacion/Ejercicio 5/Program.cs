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
            int maxIngresado;
            int sumaAnteriores = 0;
            int sumaPosteriores = 0;
            int centroNumerico;
            int anteriores;
            int posteriores;
            Console.WriteLine("Ingrese numero maximo a evaluar:");
            maxIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine("Centros numericos:");

            for (centroNumerico = 2; centroNumerico <= maxIngresado; centroNumerico++)
            {
                sumaAnteriores = 0;
                sumaPosteriores = 0;
                for (anteriores = 0; anteriores < centroNumerico; anteriores++)
                {
                    sumaAnteriores += anteriores;
                }
                for (posteriores = centroNumerico + 1; sumaPosteriores < sumaAnteriores; posteriores++)
                {
                    sumaPosteriores += posteriores;
                    if (sumaPosteriores == sumaAnteriores)
                    {
                        Console.WriteLine("{0}", centroNumerico);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
