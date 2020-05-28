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

        public static bool operator==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaDeCreacion == e2.fechaDeCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            return String.Format($"{this.nombre} fundado el {this.fechaDeCreacion}");
        }
    }
}
