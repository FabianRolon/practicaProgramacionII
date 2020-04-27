using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoManada
    {
        Unica,
        Mixta
    }

    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        static TipoManada tipo;

        public TipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }

        static Grupo()
        {
            Grupo.tipo = TipoManada.Unica;

        }

        private Grupo()
        {
            Grupo.tipo = TipoManada.Unica;
            manada = new List<Mascota>();
        }

        public Grupo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            this.Tipo = tipo;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            foreach (Mascota mascota in g.manada)
            {
                if (mascota == m)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g.manada.Add(m);
                return g;
            }
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g.manada.Remove(m);
                return g;
            }
            return g;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{g.nombre}");
            sb.AppendLine($"Integrantes:");
            foreach (Mascota mascota in g.manada)
            {
                sb.AppendLine($"{mascota.ToString()}");
            }
            return sb.ToString();
        }
    }
 }

  
