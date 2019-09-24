using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public abstract class Persona
    {

        public string Nombre { get; set; }
        public int Cuil { get; set; }

        public Persona()
        {
        }

        public Persona(string nombre, int cuil)
        {
            this.Nombre = nombre;
            this.Cuil = cuil;
        }

        public abstract string Mostrar();
    }
}
