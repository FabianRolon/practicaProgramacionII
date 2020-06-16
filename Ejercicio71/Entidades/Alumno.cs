using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private string fotoAlumno;
        private int dni;

        public Alumno(string nombre, string apellido, string ruta, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fotoAlumno = ruta;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string RutaDeLaFoto
        {
            get
            {
                return this.fotoAlumno;
            }
            set
            {
                this.fotoAlumno = value;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
    }
}
