using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            :base(apellido, documento, nombre)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.anio}º{this.division}");
                return sb.ToString();
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ExponerDatos()}");
            sb.AppendLine($"{this.AnioDivision}");
            return sb.ToString();
        }

        public override bool ValidarDocumentacion(string doc)
        {
            doc.Contains("xx-xxxx-x");
        }
    }
}
