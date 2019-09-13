using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        double cantidad;
        static double cotizRespectoDolar;

        Euro()
        {

        }
        public Euro(double cantidad)
            :this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static void SetCotizacion(string numero)
        {
            if (!double.TryParse(numero, out double auxNumero))
            {
            }
            else
                Euro.cotizRespectoDolar = auxNumero;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Euro(double euros)
        {
            return new Euro(euros);
        }

        public static explicit operator Pesos(Euro euros)
        {
            Dolar d1 = (Dolar)euros;
            Pesos auxPesos = new Pesos(0);
            Pesos p1 = new Pesos(d1.GetCantidad() * Pesos.GetCotizacion());
            return p1;
        }

        public static explicit operator Dolar(Euro euros)
        {
            return new Dolar(euros.cantidad / Euro.GetCotizacion());
        }
        public static Euro operator +(Euro euros, Pesos pesos)
        {
            return new Euro(euros.cantidad + ((Euro)pesos).cantidad);
        }
    }
}
