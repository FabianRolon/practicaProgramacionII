using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio40_CentralitaPoli
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;
        private string rutaDeArchivo;

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion, destino, origen)
        {
            this.costo = costo;
            this.rutaDeArchivo = "LlamadaLocales.xml";
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
            this.costo = costo;
        }

        public Local()
            :base()
        {
            
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
            sb.AppendLine($"Costo de duracion: {this.CostoLlamada}");
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }

        public override bool Equals(Object obj)
        {
            return obj is Local;
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
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                serializer.Serialize(xmlTextWriter, this);
                xmlTextWriter.Close();
            }
            catch (Exception e)
            {
                throw new InvalidCastException(" ", e);
            }
            return true;
        }

        public Local Leer()
        {
            Local local = new Local();
            try
            {
                XmlTextReader xmlTextReader = new XmlTextReader(this.RutaDeArchivo);
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                local = (Local)serializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
            }
            catch (Exception e)
            {
                throw new InvalidCastException(" ", e);
            }
            return local;
        }
    }
}
