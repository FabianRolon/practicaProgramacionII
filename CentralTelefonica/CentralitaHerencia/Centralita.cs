using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> listaDeLlamada;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) 
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }

         

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamada;
            }

        }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            foreach (Llamada llamadas in listaDeLlamada)
            {
                if()
            }
        }

    }
}
