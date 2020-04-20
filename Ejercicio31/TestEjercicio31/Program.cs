using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio31;

namespace TestEjercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio negocio1 = new Negocio("Supermercado");
            Cliente c1 = new Cliente("pepito");
            Cliente c2 = new Cliente("juanita");
            Cliente c3 = new Cliente("pablito");
            Cliente c4 = new Cliente("josesito");
            Cliente c5 = new Cliente("pepito");

            negocio1.Cliente = c1;
            negocio1.Cliente = c2;
            negocio1.Cliente = c3;
            negocio1.Cliente = c4;
            negocio1.Cliente = c5;

            
            Console.WriteLine("Clientes en espera: {0}\n\n", negocio1.ClientesPendientes);

            Console.WriteLine("Atendiendo cliente...\n\n");
            if (~negocio1)
            {
                Console.WriteLine("Atendido con éxito\n\n");
            }
            else
            {
                Console.WriteLine("No se pudo atender\n\n");
            }

            Console.WriteLine("<--------------------------------------------------------->\n\n");

            Console.WriteLine("Clientes en espera: {0}\n\n", negocio1.ClientesPendientes);

            Console.WriteLine("Atendiendo cliente...\n\n");
            if (~negocio1)
            {
                Console.WriteLine("Atendido con éxito\n\n");
            }
            else
            {
                Console.WriteLine("No se pudo atender\n\n");
            }

            Console.WriteLine("<--------------------------------------------------------->\n\n");

            Console.WriteLine("Clientes en espera: {0}\n\n", negocio1.ClientesPendientes);

            Console.WriteLine("Atendiendo cliente...\n\n");
            if (~negocio1)
            {
                Console.WriteLine("Atendido con éxito\n\n");
            }
            else
            {
                Console.WriteLine("No se pudo atender\n\n");
            }

            Console.WriteLine("<--------------------------------------------------------->\n\n");

            Console.WriteLine("Clientes en espera: {0}\n\n", negocio1.ClientesPendientes);

            Console.WriteLine("Atendiendo cliente...\n\n");
            if (~negocio1)
            {
                Console.WriteLine("Atendido con éxito\n\n");
            }
            else
            {
                Console.WriteLine("No se pudo atender\n\n");
            }

            Console.WriteLine("<--------------------------------------------------------->\n\n");

            Console.WriteLine("Clientes en espera: {0}\n\n", negocio1.ClientesPendientes);

            Console.WriteLine("Atendiendo cliente...\n\n");
            if (~negocio1)
            {
                Console.WriteLine("Atendido con éxito\n\n");
            }
            else
            {
                Console.WriteLine("No se pudo atender\n\n");
            }

            Console.ReadKey(); 
            
        }
    }
}
