using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEj29
{
    class Program
    {
        static void Main(string[] args)
        {

            Equipo e1 = new Equipo(2, "Alumni");
            Jugador j1 = new Jugador(32123443, "Martin");
            Jugador j2 = new Jugador(33123443, "JuanFer");
            Jugador j3 = new Jugador(12123443, "Lionel");

            if (e1 + j1)
            {
                Console.WriteLine("Se agregó con exito a {0}", j1.nombre);
            }
            else
            {
                Console.WriteLine("No se agregó a {0}", j1.nombre);
            }

            if (e1 + j2)
            {
                Console.WriteLine("Se agregó con exito {0}", j2.nombre);
            }
            else
            {
                Console.WriteLine("No se agregó {0}", j2.nombre);
            }

            if (e1 + j3)
            {
                Console.WriteLine("Se agregó con exito {0}", j3.nombre);
            }
            else
            {
                Console.WriteLine("No se agregó {0}", j3.nombre);
            }

            Console.ReadKey();
        }
    }
}
