using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Entidades
{
    [Serializable]
    public class Factura
    {
        int idFactura = 0;
        private int consumo;
        static double iva = 0.21;
        double precioUnitarioCf;
        double precioUnitarioCv;
        double municipal;
        double provincial;
        int diferenciaConsumo;
        DateTime fechaIngreso;
        double totalPago;
        
        public Factura()
        {
        }
        public Factura(int consumo)
            : this()
        {
            this.consumo = consumo;
        }
        public Factura(int consumo, double precioUnitarioCf, double precioUnitarioCv, double municipal, double provincial, DateTime fechaIngreso)
            :this(consumo)
        {
            this.precioUnitarioCf = precioUnitarioCf;
            this.precioUnitarioCv = precioUnitarioCv;
            this.municipal = municipal;
            this.provincial = provincial;
            this.fechaIngreso = fechaIngreso;
        }
        public Factura(int consumo, double precioUnitarioCf, double precioUnitarioCv, double municipal, double provincial, DateTime fechaIngreso, int idFactura)
           : this(consumo, precioUnitarioCf, precioUnitarioCv, municipal, provincial, fechaIngreso)
        {
            this.idFactura = idFactura;
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

        public double PrecioUnitarioCv
        {
            get
            {
                return precioUnitarioCv;
            }
            set
            {
                precioUnitarioCv = value;
            }
        }

        public int Consumo
        {
            get 
            {
                return consumo;
            }
            set
            {
                consumo = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }
            set
            {
                fechaIngreso = value;
            }
        }

        public int IdFactura
        {
            get
            {
                return idFactura;
            }
            set
            {
                idFactura = value;
            }
        }
        public double Municipal
        {
            get
            {
                return municipal;
            }
            set
            {
                municipal = value;
            }
        }

        public double Provincial
        {
            get
            {
                return provincial;
            }
            set
            {
                provincial = value;
            }
        }

        public int DiferenciaConsumo { get => diferenciaConsumo; set => diferenciaConsumo = value; }
        public double TotalPago { get => totalPago; set => totalPago = value; }

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
            return ((CalculoCargoFijo(f) + CalculoCargoVariable(f))*(f.municipal / 100));
        }

        public double ContribucionPrivincial(Factura f)
        {
            return ((CalculoCargoFijo(f) + CalculoCargoVariable(f)) * (f.provincial / 100));
        }

        public double CalculoIva(Factura f)
        {
            return ((CalculoCargoFijo(f) + CalculoCargoVariable(f)) * iva );
        }

        public double TotalPagar(Factura f)
        {
            return Math.Round((CalculoCargoFijo(f) + CalculoCargoVariable(f) + ContribucionMunicipal(f) + ContribucionPrivincial(f) + CalculoIva(f)), 2);
        }

        /// <summary>
        /// Restar dos facturas respectivamente 
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns>Devuelve la diferencia de consumo de la primera respecto la segunda</returns>
        public static Factura operator -(Factura f1, Factura f2)
        {
            int resultado = f2.consumo - f1.consumo;
            return new Factura(resultado, f2.PrecioUnitarioCf, f2.PrecioUnitarioCv, f2.Municipal, f2.Provincial, f2.FechaIngreso);
        }

        public int Guardar() 
        {
            try
            {
                SaveFileDialog dialogo = new SaveFileDialog(); //abre ventana para elegir donde guardar el archivo
                if(dialogo.ShowDialog() == DialogResult.OK) //espera el resultado Ok, sino el usuario canceló
                {
                    FileStream st = new FileStream(dialogo.FileName, FileMode.Create); //dialogo.FileName es la ruta completa donde se eligio guardar, FileMode.Create crea el archivo o lo reemplaza si ya existe
                    BinaryFormatter binfor = new BinaryFormatter(); //permite hacer la serializacion
                    binfor.Serialize(st, this); //Se le pasa a la instacia de binnaryFormatter el stream creado y el objeto a serializar
                    st.Close();
                    return 0;
                }
                else
                {
                    return 1; //el usuario cancelo
                }
            }
            catch(Exception)
            {
                return 2;
            }
        }  
    }
}
