using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

        Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
            :this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Pesos(Dolar dolares)
        {
            return new Pesos(dolares.cantidad * Pesos.GetCotizacion());
        }
    }
}
