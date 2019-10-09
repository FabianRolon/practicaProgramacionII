using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        int cantSatelites;
        Tipo tipo;
        List<Astro> satelites;

        public Planeta(int duraOrbita, int duraRotacion, string nombre)
            : base(duraOrbita, duraRotacion, nombre)
        {
            satelites = new List<Astro>();
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre, int cantSatelites, Tipo tipo)
            : this(duraOrbita, duraRotacion, nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }

        public List<Astro> Satelites
        {
            get
            {
                return satelites;
            }
        }

        public static bool operator +(Planeta planeta, Satelite satelite)
        {
            if (satelite is Satelite)
            {
                planeta.Satelites.Add(satelite);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            foreach (Satelite satelites in planeta.Satelites)
            {
                if(satelites.Nombre == satelite.Nombre)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite); 
        }

        public static bool operator ==(Planeta planeta, Planeta planeta2)
        {
            if(planeta.nombre == planeta2.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }

        public new string Rotar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Orbitar el planeta: {0}", nombre);
            return str.ToString();
        }

        public override string Orbitar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Orbitar el planeta: {0}", nombre);
            return str.ToString();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.Mostrar());
            str.AppendFormat("Cantidad de satelites: {0}\nTipo: {1}\n", cantSatelites, tipo);
            str.AppendLine("Satelites del planeta: ");
            foreach (Satelite sat in Satelites)
            {
                str.AppendLine(sat.ToString());
            }
            return str.ToString();
        }
    }
}
