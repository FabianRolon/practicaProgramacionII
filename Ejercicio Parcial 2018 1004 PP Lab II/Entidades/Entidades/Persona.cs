using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }

        #region Propiedades
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        #endregion

        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}\nApellido: {1}\nDni: {2}\nEdad {3}\n", Nombre, Apellido, Dni, Edad);
            return str.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
