using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Factura
    {
        private int consumo;
        static int iva = 21;
        double precioUnitarioCf;
        double precioUnitarioCv;
        double municipal;
        double provincial;
        
        public Factura()
        {
        }
        public Factura(int consumo)
            : this()
        {
            this.consumo = consumo;
        }
        public Factura(int consumo, double precioUnitarioCf, double precioUnitarioCv)
            :this(consumo)
        {
            this.precioUnitarioCf = precioUnitarioCf;
            this.precioUnitarioCv = precioUnitarioCv;
        }

        public double PrecioUnitarioCf
        {
            get
            {
                return precioUnitarioCf;
            }
            set
            {
                precioUnitarioCf = value;
            }
        }

        public double CalculoCargoFijo(Factura f)
        {
            return f.precioUnitarioCf;     
        }

        public double CalculoCargoVariable(Factura f)
        {
            return f.consumo * f.precioUnitarioCv;
        }

        public double ContribucionMunicipal(Factura f)
        {
            return (CalculoCargoFijo(f) + CalculoCargoVariable(f))*(f.municipal / 100);
        }

        public double ContribucionPrivincial(Factura f)
        {
            return (CalculoCargoFijo(f) + CalculoCargoVariable(f)) * (f.provincial / 100);
        }

        public double CalculoIva(Factura f)
        {
            return (CalculoCargoFijo(f) + CalculoCargoVariable(f)) * (iva / 100);
        }

        public double TotalPagar(Factura f)
        {
            return CalculoCargoFijo(f) + CalculoCargoVariable(f) + ContribucionMunicipal(f) + ContribucionPrivincial(f) + CalculoIva(f);
        }

        /// <summary>
        /// Restar dos facturas respectivamente 
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns>Devuelve la diferencia de consumo de la primera respecto la segunda</returns>
        public static double operator -(Factura f1, Factura f2)
        {
            return f1.consumo - f2.consumo;
        }


    }
}
