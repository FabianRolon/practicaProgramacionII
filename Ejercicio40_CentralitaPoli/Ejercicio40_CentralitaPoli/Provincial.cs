using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio40_CentralitaPoli
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;
        private string rutaDeArchivo;
                
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.rutaDeArchivo = "LlamadaProvinciales.xml";
        }
        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial()
            :base()
        {
            
        }

        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return this.Duracion * 0.99f;
                case Franja.Franja_2:
                    return this.Duracion * 1.25f;
                case Franja.Franja_3:
                    return this.Duracion * 0.66f;
                default:
                    return 0;
            }
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public string RutaDeArchivo 
        {
            get 
            {
                return this.rutaDeArchivo; 
            }
            set
            {
                this.rutaDeArchivo = value;
            } 
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo Llamada: {this.CostoLlamada}");
            sb.AppendLine($"Franja Horaria: {this.franjaHoraria}");
            return sb.ToString();
        }

        public override bool Equals(Object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(this.RutaDeArchivo, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                serializer.Serialize(xmlTextWriter, this);
                xmlTextWriter.Close();
            }
            catch (Exception e)
            {
                throw new InvalidCastException(" ", e);
            }
            return true;
        }

        public Provincial Leer()
        {
            Provincial provincial = new Provincial();
            try
            {
                XmlTextReader xmlTextReader = new XmlTextReader(this.RutaDeArchivo);
                XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                provincial = (Provincial)serializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
            }
            catch (Exception e)
            {
                throw new InvalidCastException(" ", e);
            }
            return provincial;
        }
    }
}
