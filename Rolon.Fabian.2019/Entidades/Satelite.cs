using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public Satelite(int duraOrbita, int duraRotacion, string nombre)
            :base(duraOrbita, duraRotacion, nombre)
        {
        }

        public string Nombre
        {
            get
            {
                return this.Nombre;
            }
        }

        public override string Orbitar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Orbitar el satelite: {0}", Nombre);
            return str.ToString();
        }

        public override string ToString()
        {
           return base.Mostrar();
        }


    }
}
