using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    public class Pesos
    {
        double cantidad;
        static double cotizRespectoDolar;

        Pesos()
        {
            Pesos.cotizRespectoDolar = 55.93;
        }
        public Pesos(double cantidad)
            :this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        #region Conversiones
        public static explicit operator Dolar(Pesos pesos)
        {
            return new Dolar(pesos.cantidad / Pesos.cotizRespectoDolar);
        }

        public static explicit operator Euro(Pesos pesos)
        {
            return new Euro(pesos.cantidad / (Euro.GetCotizacion()));
        }

        public static implicit operator Pesos(double pesos)
        {
            return new Pesos(pesos);
        }
        #endregion

        public static Pesos operator +(Pesos pesos, Dolar dolares)
        {

            return new Pesos(pesos.cantidad + ((Pesos)dolares).cantidad);
        }

        public static Pesos operator -(Pesos pesos, Dolar dolares)
        {
            return new Pesos(pesos.cantidad - ((Pesos)dolares).cantidad);
        }

        public static Pesos operator +(Pesos pesos, Euro euros)
        {
            return new Pesos(pesos.cantidad + ((Pesos)euros).cantidad);
        }

        public static Pesos operator -(Pesos pesos, Euro euros)
        {
            return new Pesos(pesos.cantidad - ((Pesos)euros).cantidad);
        }

        public static bool operator ==(Pesos pesos, Dolar dolares)
        {
            if (pesos.cantidad == ((Pesos)dolares).GetCantidad())
            {
                return true; 
            }
            else
                return false;
        }

        public static bool operator !=(Pesos pesos, Dolar dolares)
        {
            return !(pesos == dolares);
        }

        public static bool operator ==(Pesos pesos, Euro euros)
        {
            if (pesos.cantidad == ((Pesos)euros).GetCantidad())
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Pesos pesos, Euro euros)
        {
            return !(pesos == euros);
        }

        public static bool operator ==(Pesos pesosUno, Pesos pesosDos)
        {
            if (pesosUno.cantidad == pesosDos.cantidad)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Pesos pesosUno, Pesos pesosDos)
        {
            return !(pesosUno == pesosDos);
        }


    }

}
