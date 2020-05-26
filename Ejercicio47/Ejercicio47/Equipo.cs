using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaDeCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaDeCreacion = fecha;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Ficha()
        {
            return String.Format($"{this.nombre} fundado el {this.fechaDeCreacion}");
        }
    }
}
