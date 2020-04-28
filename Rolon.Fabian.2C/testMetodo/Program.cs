using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            string prueba;

            bool ValidarDocumentacion(string doc)
            {
                bool retorno = false;
                if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
                {
                    foreach (char c in doc)
                    {
                        if (!(char.IsDigit(c) || c == '-'))
                        {
                            return retorno;
                        }
                    }
                    retorno = true;
                }
                return retorno;
            }       


            Console.WriteLine("Ingrese un numero de documento con este formato XX-XXXX-X");
            prueba = Console.ReadLine();
            if (ValidarDocumentacion(prueba))
            {
                Console.WriteLine("Numero Correcto");
            }
            else
            {
                Console.WriteLine("Numero Incorrecto");
            }

            Console.ReadKey();
        }
    }
}
