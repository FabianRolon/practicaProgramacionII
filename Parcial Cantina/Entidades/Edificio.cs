using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Edificio
    {
        private Cantina[] cantinas;
        private const short limiteCantinas = 2;
        static Edificio singleton;

        private Edificio()
        {
            cantinas = new Cantina[limiteCantinas];
        }
        static Edificio()
        {
            singleton = new Edificio();
        }

        public static Edificio GetBar()
        {
            return singleton;
        }

        public static bool operator +(Edificio e, Cantina c)
        {
            for (int i = 0; i < e.cantinas.Length; i++)
            {
                if(e.cantinas[i] is null)
                {
                    e.cantinas[i] = c;
                    return true;
                }
            }
            return false;
        }
    }
}
