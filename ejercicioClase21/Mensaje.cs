using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ejercicioClase21
{
    public class Mensaje : Imensaje
    {
        string usuario;
        string texto;
        DateTime hora;

        public Mensaje()
        {
            hora = new DateTime();
        }

        public Mensaje(string usuario, string texto, DateTime hora)
            : this()
        {
            this.usuario = usuario;
            this.texto = texto;
            this.hora = hora;
        }

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }

        public string Texto
        {
            get
            {
                return this.texto;
            }
            set
            {
                this.texto = value;
            }
        }

        public DateTime Hora
        {
            get
            {
                return this.hora;
            }
            set
            {
                this.hora = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}  {1}  {2}", this.Usuario, Texto, Hora);
            return sb.ToString();
        }

        void Serializar()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Y:\mensajes";
            XmlTextWriter wr = new XmlTextWriter(path, Encoding.UTF8);
            XmlSerializer ser;
            ser = new XmlSerializer(typeof(Mensaje));
            ser.Serialize(wr, this);
            wr.Close();
        }
        public static List<Mensaje> Deserializar()
        {
            List<Mensaje> salida = new List<Mensaje>();
            foreach (string item in Directory.GetFiles(@"Y:\Mensajes\", "*.xml"))
            {
                XmlTextReader xmlText = new XmlTextReader(item);
                XmlSerializer ser = new XmlSerializer(typeof(Mensaje));
                salida.Add((Mensaje)ser.Deserialize(xmlText));
                xmlText.Close();
            }

            return salida;
        }
    }
}
