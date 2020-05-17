using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40_CentralitaPoli
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
            this.costo = costo;
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo de duracion: {this.CostoLlamada}");
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }

        public override bool Equals(Object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
