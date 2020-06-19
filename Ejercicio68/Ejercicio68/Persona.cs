using System;
using System.Text;

namespace Ejercicio68
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EnventoString;

        public Persona()
        {
            this.nombre = String.Empty;
            this.apellido = String.Empty;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (this.nombre == String.Empty)
                {
                    this.nombre = value;
                    this.EnventoString.Invoke("Se agregó el nombre correctamente");
                }
                else
                {
                    this.nombre = value;
                    this.EnventoString.Invoke("Se modificó el nombre correctamente");
                }
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
                if (this.apellido == String.Empty)
                {
                    this.apellido = value;
                    this.EnventoString.Invoke("Se agregó el apellido correctamente");
                }
                else
                {
                    this.apellido = value;
                    this.EnventoString.Invoke("Se modificó el apellido correctamente");
                }
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} {this.apellido}");
            return sb.ToString();
        }
    }
}
