using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected string nroOrigen;
        protected string nroDestino;
        protected float duracion;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public Llamada(string nroOrigen, string nroDestino, float duracion)
        {
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
            this.duracion = duracion;
        }

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }


        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Numero de Origen: {0}\n Numero de Destino: {1}\n Duracion: {2}\n", NroOrigen, NroDestino, Duracion);
            return str.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }
    }
}
