using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

        Dolar()
        {

        }
        public Dolar(double cantidad)
            : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static void SetCotizacion(string numero)
        {
            if (!double.TryParse(numero, out double auxNumero))
            {
            }
            else
                Dolar.cotizRespectoDolar = auxNumero;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static implicit operator Dolar(double dolares)
        {
            return new Dolar(dolares);
        }

        public static explicit operator Pesos(Dolar dolares)
        {
            return new Pesos(dolares.cantidad * Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Dolar dolares)
        {
            return new Euro(dolares.cantidad * Euro.GetCotizacion());
        }
        public static Dolar operator +(Dolar dolares, Pesos pesos)
        {
            return new Dolar(dolares.cantidad + ((Dolar)pesos).cantidad);
        }

        public static Dolar operator -(Dolar dolares, Pesos pesos)
        {
            return new Dolar(dolares.cantidad - ((Dolar)pesos).cantidad);
        }
        public static Dolar operator +(Dolar dolares, Euro euros)
        {
            return new Dolar(dolares.cantidad + ((Dolar)euros).cantidad);
        }

        public static Dolar operator -(Dolar dolares, Euro euros)
        {
            return new Dolar(dolares.cantidad - ((Dolar)euros).cantidad);
        }

        public static bool operator ==(Dolar dolares, Pesos pesos)
        {
            if (dolares.cantidad == ((Dolar)pesos).GetCantidad())
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Dolar dolares, Pesos pesos)
        {
            return !(dolares == pesos);
        }

        public static bool operator ==(Dolar dolares, Euro euros)
        {
            if (dolares.cantidad == ((Dolar)euros).GetCantidad())
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Dolar dolares, Euro euros)
        {
            return !(dolares == euros);
        }

        public static bool operator ==(Dolar dolaresUno, Dolar dolaresDos)
        {
            if (dolaresUno.cantidad == dolaresDos.GetCantidad())
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Dolar dolaresUno, Dolar dolaresDos)
        {
            return !(dolaresUno == dolaresDos);
        }


    }
}
