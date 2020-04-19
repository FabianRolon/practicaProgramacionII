using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej30;

namespace TestEj30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c1 = new Competencia(3, 30);
            AutoF1 a1 = new AutoF1(44, "Ferrari");
            AutoF1 a2 = new AutoF1(10, "Mercedes");
            AutoF1 a3 = new AutoF1(07, "Renault");
            AutoF1 a4 = new AutoF1(27, "Red Bull");
            
            if (c1 + a1)
            {
                Console.WriteLine("Se agregó con exito");
                Console.WriteLine(a1.Mostrardatos());
            }
            else
            {
                Console.WriteLine("No se agregó");
            }
            
            if (c1 + a1)
            {
                Console.WriteLine("Se agregó con exito");
                Console.WriteLine(a1.Mostrardatos());
            }
            else
            {
                Console.WriteLine("No se agregó\n");
            }

            if (c1 + a2)
            {
                Console.WriteLine("Se agregó con exito");
                Console.WriteLine(a2.Mostrardatos());
            }
            else
            {
                Console.WriteLine("No se agregó");
            }

            if (c1 + a3)
            {
                Console.WriteLine("Se agregó con exito");
                Console.WriteLine(a3.Mostrardatos());
            }
            else
            {
                Console.WriteLine("No se agregó");
            }

            if (c1 + a4)
            {
                Console.WriteLine("Se agregó con exito");
                Console.WriteLine(a4.Mostrardatos());
            }
            else
            {
                Console.WriteLine("No se agregó");
            }

            if (c1 - a1)
            {
                Console.WriteLine("Se quitó con exito");
                Console.WriteLine(a1.Mostrardatos());
            }
            else
            {
                Console.WriteLine("No se eliminó");
            }

            Console.ReadKey();

            Console.WriteLine("--------------------------------------------:\n");
            Console.WriteLine("Datos de la competencia:\n");
            Console.WriteLine(c1.MostrarDatos());

            Console.ReadKey();
        }
    }
    
}
