using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ejercicio40_CentralitaPoli;
using LoremNET;

namespace MainConHilos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Central Fabi");
            c.RutaDeArchivo = "log.txt";
            Generar generar = new Generar(c);
           
            Thread hiloGeneradorDeLlamadas = new Thread(generar.GenerarLlamada);
            hiloGeneradorDeLlamadas.Start();
            int salir = 1;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CENTRAL TELEFONICA\n\n");
            sb.AppendLine("1- Ver lista de llamadas");
            sb.AppendLine("2- Ver ganancias por llamadas locales");
            sb.AppendLine("3- Ver ganancias por llamadas provinciales");
            sb.AppendLine("4- Ver ganancias totales");
            sb.AppendLine("5- Salir");

            do
            {
                Console.WriteLine(sb.ToString());
                string nroMenu = Console.ReadLine();
                switch (nroMenu)
                {
                    case "1":
                        foreach (Llamada llamada in c.Llamadas)
                        {
                            Console.WriteLine(llamada.ToString());
                            Console.WriteLine("<------------------------->");
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Las ganancias por local son : {0}",c.GananciasPorLocal);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Las ganancias por provincial son : {0}", c.GananciasPorProvincial);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Las ganancias totales son : {0}", c.GananciasPortotal);
                        Console.ReadKey();
                        break;
                    case "5":
                        salir = 0;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta");
                        break;
                }
                Console.Clear();
            } while (salir != 0);

            hiloGeneradorDeLlamadas.Abort();
        }
    }
}
