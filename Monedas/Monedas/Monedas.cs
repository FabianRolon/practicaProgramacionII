using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Euro
    {
        double cantidad;
        static double cotizRespectoDolar;

        Euro()
        {
            Euro.cotizRespectoDolar = 1.16;
        }
        public Euro(double cantidad)
            : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
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
            return new Pesos(((Dolar)euros).GetCantidad() * Pesos.GetCotizacion());
        }

        public static explicit operator Dolar(Euro euros)
        {
            return new Dolar(euros.cantidad * Euro.GetCotizacion());
        }
        public static Euro operator +(Euro euros, Pesos pesos)
        {
            return new Euro(euros.cantidad + ((Euro)pesos).cantidad);
        }

        public class Pesos
        {
            double cantidad;
            static double cotizRespectoDolar;

            Pesos()
            {
                Pesos.cotizRespectoDolar = 55.93;
            }
            public Pesos(double cantidad)
                : this()
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

        public class Dolar
        {
            double cantidad;
            static double cotizRespectoDolar;

            Dolar()
            {
                Dolar.cotizRespectoDolar = 1;
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

            public double GetCantidad()
            {
                return this.cantidad;
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
}
