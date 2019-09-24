using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {

        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }

        }

        public Local(Llamada llamada, float costo) : this(llamada.NroDestino, llamada.NroOrigen, llamada.Duracion, costo)
        {
        }

        public Local(string nroDestino, string  nroOrigen, float duracion , float costo) :base(nroDestino, nroOrigen, duracion)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        { 
            return  this.Duracion * costo;
        }
    
        public new string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Numero de Origen: {0}\n Numero de Destino: {1}\n Duracion: {2}\n Costo Llamada {3}", NroOrigen, NroDestino, Duracion, CostoLlamada);
            return str.ToString();
        }
    }
}
