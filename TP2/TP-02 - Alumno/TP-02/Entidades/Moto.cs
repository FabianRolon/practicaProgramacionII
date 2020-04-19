using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public Moto( string chasis, EMarca marca, ConsoleColor color) :base(chasis, marca, color)
        {
            
        }

        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return 0;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(this.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
