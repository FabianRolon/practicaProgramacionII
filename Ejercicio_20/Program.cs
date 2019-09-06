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
            Pesos pesosDos = new Pesos(100);
            Dolar dolarUno = new Dolar(20);
            Pesos suma = pesosUno + dolarUno;
            double sumaLoca = dolarUno.GetCantidad() * Pesos.GetCotizacion();

            Console.WriteLine("La suma de {0} pesos y {1} Dolares da: {2} pesos", pesosUno.GetCantidad(), dolarUno.GetCantidad(), suma.GetCantidad());
            Console.ReadKey();
        }
    }
}
