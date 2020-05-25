using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio42;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase;
            try
            {
                otraClase = new OtraClase();
                otraClase.UnMetodoDeInstancia();
            }catch(MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                if(!(ex.InnerException is null))
                {
                    Exception auxEx = ex.InnerException;

                    do
                    {
                        Console.WriteLine(auxEx.Message);
                        auxEx = auxEx.InnerException;

                    } while (!(auxEx is null));
                }
            }
            Console.ReadKey();
        }
    }
}
