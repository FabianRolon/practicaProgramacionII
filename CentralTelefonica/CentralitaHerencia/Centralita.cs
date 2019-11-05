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
            {
                float sumador = 0;
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                {
                    foreach (Llamada llamada in listaDeLlamada)
                    {
                        if (llamada is Local)
                            sumador += ((Local)llamada).CostoLlamada;
                    }
                }
                if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                {
                    foreach (Llamada llamada in listaDeLlamada)
                    {
                        if (llamada is Provincial)
                            sumador += ((Provincial)llamada).CostoLlamada;
                    }
                }
                return sumador;
            }
        }

    }
}
