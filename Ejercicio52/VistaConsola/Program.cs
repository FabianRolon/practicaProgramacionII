using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio52;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(3);
            Boligrafo miBoligrafo = new Boligrafo(4, ConsoleColor.Green);
            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            
            Console.ReadKey();
            
            Console.WriteLine("Prueba Ejercicio 53");
            Cartuchera1 cartuchera1 = new Cartuchera1();
            Cartuchera2 cartuchera2 = new Cartuchera2();
            Lapiz miLapiz2 = new Lapiz(3);
            Boligrafo miBoligrafo2 = new Boligrafo(1, ConsoleColor.Red);
            Lapiz miLapiz3 = new Lapiz(2);
            Boligrafo miBoligrafo3 = new Boligrafo(3, ConsoleColor.Blue);
            Lapiz miLapiz4 = new Lapiz(2);
            Boligrafo miBoligrafo4 = new Boligrafo(3, ConsoleColor.Magenta);
            
            cartuchera1.Lista.Add(miLapiz);
            cartuchera1.Lista.Add(miLapiz2);
            cartuchera1.Lista.Add(miLapiz3);
            cartuchera1.Lista.Add(miLapiz4);
            cartuchera1.Lista.Add(miBoligrafo);
            cartuchera1.Lista.Add(miBoligrafo2);
            cartuchera1.Lista.Add(miBoligrafo3);
            cartuchera1.Lista.Add(miBoligrafo4);
           
            cartuchera2.ListaLapices.Add(miLapiz);
            cartuchera2.ListaLapices.Add(miLapiz2);
            cartuchera2.ListaLapices.Add(miLapiz3);
            cartuchera2.ListaLapices.Add(miLapiz4);
            cartuchera2.ListaBoligrafos.Add(miBoligrafo);
            cartuchera2.ListaBoligrafos.Add(miBoligrafo2);
            cartuchera2.ListaBoligrafos.Add(miBoligrafo3);
            cartuchera2.ListaBoligrafos.Add(miBoligrafo4);

            bool flag;
            Console.WriteLine("Prueba Elementos Cartuchera 1");
            do
            {
                flag = cartuchera1.ProbarElementos();
                Console.WriteLine("{0}",flag);
            }while (flag);
             


            Console.ReadKey();
            
            Console.WriteLine("Prueba Elementos Cartuchera 2");
            do
            {
                flag = cartuchera2.ProbarElementos();
                Console.WriteLine("{0}", flag);
            } while (flag);

            Console.ReadKey();
        }
    }
}
