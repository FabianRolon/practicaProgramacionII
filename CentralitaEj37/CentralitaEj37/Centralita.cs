using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaEj37
{
    public class Centralita
    {
        private List<Llamada> listaDeLLamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreDeLaEmpresa)
            :this()
        {
            this.razonSocial = nombreDeLaEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamda.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamda.Provincial);
            }
        }

        public float GananciasPortotal
        {
            get
            {
                return CalcularGanancia(TipoLlamda.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLLamadas;
            }
        }

        private float CalcularGanancia(TipoLlamda tipo)
        {
            float totalLocal = 0;
            float totalProvincial = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                    totalLocal += ((Local)llamada).CostoLlamada;
                if (llamada is Provincial)
                    totalProvincial += ((Provincial)llamada).CostoLlamada;
            }
            
            switch (tipo)
            {
                case TipoLlamda.Local:
                    return totalLocal;
                case TipoLlamda.Provincial:
                    return totalProvincial;
                case TipoLlamda.Todas:
                    return totalLocal + totalProvincial;
                default:
                    return 0;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciasPortotal}");
            sb.AppendLine($"Ganancia Local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciasPorProvincial}");
            sb.AppendLine($"Detalle de llamada:");
            foreach (Llamada llamada in Llamadas)
            {
                sb.AppendLine($"{llamada.Mostrar()}");
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
