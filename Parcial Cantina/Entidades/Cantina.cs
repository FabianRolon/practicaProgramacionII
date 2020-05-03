using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;


        public Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
            this.botellas = new List<Botella>(espacios);
        }

        public List<Botella> Botellas
        {
            get
            {
                return botellas;
            }
        }

        public static Cantina GetCantina(int espacios)
        {
             return new Cantina(espacios);
        }

        public static bool operator +(Cantina c,Botella b)
        {
            if(!(c is null) && c.Botellas.Count < c.espaciosTotales)
            {
                c.Botellas.Add(b);
                return true;
            }
            return false;
        }

        public static bool operator ==(Cantina c, Botella b)
        {
            if (!(c is null) && !(b is null))
            {
                foreach (Botella botella in c.Botellas)
                {
                    if (b == botella)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public static bool operator !=(Cantina c, Botella b)
        {
            return !(c == b);
        }
    }
}
