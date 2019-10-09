using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        int duracionOrbita;
        int duracionRotacion;
        protected string nombre;

        protected Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;
        }

        public abstract string Orbitar();

        protected string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}\nOrbira: {1}\nRotacion: {2}", nombre, duracionOrbita, duracionRotacion);
            return str.ToString();
        }

        public virtual string Rotar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Rotando. Tiempo  estimado: {0}", duracionRotacion);
            return str.ToString();
        }
    }
}
