using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        DateTime fechaDeIngreso;

        public Profesor(string nombre, string apellido, string documento)
            :base(apellido, documento, nombre){}

        public Profesor(string nombre, string apellido, string documento, DateTime fecha)
            :this(nombre, apellido, documento)
        {
            this.fechaDeIngreso = fecha;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ExponerDatos()}");
            sb.AppendLine($"{this.fechaDeIngreso}");
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            if (doc.Length == 9)
            {
                foreach (char c in doc)
                {
                    if (!(char.IsDigit(c)))
                    {
                        return retorno;
                    }
                }
                retorno = true;
            }
            return retorno;
        }
    }
}
