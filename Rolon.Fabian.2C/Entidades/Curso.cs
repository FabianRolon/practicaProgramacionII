using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        Divisiones division;
        Profesor profesor;

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
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

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Curso: {c.AnioDivision}");
            sb.AppendLine($"Profesor: {c.profesor}");
            sb.AppendLine($"Alumnos:");
            foreach (Alumno alumno in c.alumnos)
            {
                sb.AppendLine($"{alumno.ExponerDatos()}");
            }
            return sb.ToString();
        }

        public implicit bool operator ==(Curso c, Alumno a)
        {

        }
    }
}
