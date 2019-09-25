using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) :base(origen, destino, duracion)
        {
            franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada) :this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return (float)0.99 * duracion;

                case Franja.Franja_2:
                    return (float)1.25 * duracion;

                case Franja.Franja_3:
                    return (float)0.66 * duracion;
                default:
                    return 0;
            }
        }

        public new string  Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Numero de Origen: {0}\n Numero de Destino: {1}\n Duracion: {2}\n Costo Llamada {3} Franja horaria: {4}", NroOrigen, NroDestino, Duracion, CostoLlamada, franjaHoraria);
            return str.ToString();
        }
    }
}
