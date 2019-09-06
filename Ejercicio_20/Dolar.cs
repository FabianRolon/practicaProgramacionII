using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

        Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
    }
}
