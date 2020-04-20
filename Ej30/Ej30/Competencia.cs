using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej30
{
#pragma warning disable CS0660, CS0661
    public class Competencia
    {
        short cantidadDeCompetidores;
        short cantidadDeVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadDeCompetidores, short cantidadDeVueltas)
            :this()
        {
            this.cantidadDeCompetidores = cantidadDeCompetidores;
            this.cantidadDeVueltas = cantidadDeVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadDeVueltas}");
            sb.AppendLine($"Cantidad de competidores: {this.cantidadDeCompetidores}\n");
            sb.AppendLine($"Competidores:\n");
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine($"{auto.Mostrardatos()}");
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool flag = false;
            foreach (AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {

            bool flag = false;
            if (c.competidores.Count() < c.cantidadDeCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadDeVueltas;
                Random combustible = new Random();
                a.CantidadDeCombustible = (short)combustible.Next(15, 100);
                flag = true;
            }
            return flag;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool flag = false;
            if ( c == a)
            {
                c.competidores.Remove(a);
                a.EnCompetencia = false;
                a.CantidadDeCombustible = 0;
                a.VueltasRestantes = 0;
                flag = true;
            }
            return flag;
        }
    }
}
