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
        private static Cantina singleton;

        private Cantina(int espacios)
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
            if(Cantina.singleton is null)
            {
                return new Cantina(espacios);
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacios;
                return singleton;
            }
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
    }
}
