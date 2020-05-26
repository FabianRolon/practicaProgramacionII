using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Torneo<T> where T: Equipo
    {
        private List<T> equipos;
        private string nombre;
        Random rand = new Random();
        public Torneo()
        {
            equipos = new List<T>();
        }
        public Torneo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T e)
        {
            foreach (T equipo in torneo.equipos)
            {
                if (e == equipo)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T e)
        {
            return !(torneo == e);
        }
        public static bool operator +(Torneo<T> torneo, T e)
        {
            if(torneo != e)
            {
                torneo.equipos.Add(e);
                return true;
            }
            return false;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.nombre}");
            sb.AppendLine($"Equipos:");
            foreach (T e in this.equipos)
            {
                sb.AppendLine($"{e.Nombre}");
            }
            return sb.ToString();
        }

        private string CalcularPartido(T parametroUno, T parametroDos)
        {

            int i = rand.Next(0,10);
            int j = rand.Next(0,10);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{parametroUno.Nombre} ({i}) - ({j}) {parametroDos.Nombre}");
            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                int index1 = rand.Next(0, this.equipos.Count - 1);
                int index2 = rand.Next(0, this.equipos.Count - 1);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(CalcularPartido(this.equipos[index1], this.equipos[index2]));
                return sb.ToString();
            }
        }
    }
}
