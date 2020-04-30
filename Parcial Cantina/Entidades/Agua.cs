using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
        }
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.GenerarInforme()}");
            return sb.ToString();
        }

        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        public int ServirMedida(int medida)
        {
            int retorno = 0;
            if (medida <= this.contenidoML)
            {
                this.contenidoML -= medida;
                retorno = medida;
            }
            else
            { 
                retorno = this.contenidoML;
                this.contenidoML = 0;
            }
            return retorno;
        }





    }
}
