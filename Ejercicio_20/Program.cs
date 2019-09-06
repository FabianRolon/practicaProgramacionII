using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesos pesosUno = new Pesos(200);
            Dolar dolarUno = new Dolar(20);
            Pesos suma = pesosUno + dolarUno;

            double var = suma.GetCantidad();

            Console.WriteLine("La suma de 20 dolares y 200 pesos da: {0} pesos", var);
            Console.ReadKey();
        }
    }
}
