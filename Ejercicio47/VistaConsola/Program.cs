using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio47;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipo> SuperLiga = new Torneo<Equipo>("SuperLiga");
            Torneo<Equipo> Nacional = new Torneo<Equipo>("Nacional Basquet");
            DateTime fecha = new DateTime(1901, 05, 25);
            EquipoFutbol River = new EquipoFutbol("River Plate", fecha);
            DateTime fecha2 = new DateTime(1905, 4, 3);
            EquipoFutbol Boca = new EquipoFutbol("Boca Juniors", fecha2);
            DateTime fecha3 = new DateTime(1905, 01, 1);
            EquipoFutbol Independiente = new EquipoFutbol("Independiente", fecha);
            DateTime fecha4 = new DateTime(1911, 07, 25);
            EquipoBasquet SanLorenzo = new EquipoBasquet("San Lorenzo", fecha4);
            DateTime fecha5 = new DateTime(1921, 05, 12);
            EquipoBasquet Cordoba = new EquipoBasquet("Cordoba", fecha5);
            DateTime fecha6 = new DateTime(1901, 02, 24);
            EquipoBasquet Jujuy = new EquipoBasquet("Jujuy", fecha6);
            
            if(SuperLiga + River && Nacional + River)
            {
                Console.WriteLine("Se agregó al torneo");
            }
            else
            {
                Console.WriteLine("No se agregó al torneo");
            }
            if (SuperLiga + Boca && Nacional + Boca)
            {
                Console.WriteLine("Se agregó al torneo");
            }
            else
            {
                Console.WriteLine("No se agregó al torneo");
            }
            if (SuperLiga + Independiente && Nacional + Independiente)
            {
                Console.WriteLine("Se agregó al torneo");
            }
            else
            {
                Console.WriteLine("No se agregó al torneo");
            }
            if (Nacional + SanLorenzo && SuperLiga + SanLorenzo)
            {
                Console.WriteLine("Se agregó al torneo");
            }
            else
            {
                Console.WriteLine("No se agregó al torneo");
            }
            if (Nacional + Cordoba && SuperLiga + Cordoba)
            {
                Console.WriteLine("Se agregó al torneo");
            }
            else
            {
                Console.WriteLine("No se agregó al torneo");
            }
            if (Nacional + Jujuy && SuperLiga + Jujuy)
            {
                Console.WriteLine("Se agregó al torneo");
            }
            else
            {
                Console.WriteLine("No se agregó al torneo");
            }
            
            Console.ReadKey();

            Console.WriteLine("Informacion de los torneos");

            Console.WriteLine(SuperLiga.Mostrar());
            
            Console.WriteLine(Nacional.Mostrar());
            
            Console.ReadKey();

            Console.WriteLine("Se juegan los partidos:");

            Console.WriteLine(SuperLiga.JugarPartido);
            Console.WriteLine(SuperLiga.JugarPartido);
            Console.WriteLine(SuperLiga.JugarPartido);

            Console.WriteLine(Nacional.JugarPartido);
            Console.WriteLine(Nacional.JugarPartido);
            Console.WriteLine(Nacional.JugarPartido);
            Console.ReadKey();
        }
    }
}
