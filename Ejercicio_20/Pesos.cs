using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Pesos
    {
        double cantidad;
        static double cotizRespectoDolar;

        Pesos()
        {
            Pesos.cotizRespectoDolar = 55.93;
        }
        public Pesos(double cantidad)
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
            Pesos auxPesos = new Pesos(pesos);
            return auxPesos;
        }
        #endregion

        /*public static Pesos operator +(Pesos pesos, Dolar dolares)
        {
            return 
        }*/
    }
}
