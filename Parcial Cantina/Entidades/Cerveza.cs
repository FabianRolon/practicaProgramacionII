using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML)
            : this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        {
        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.GenerarInforme()}");
            sb.AppendLine($"Tipo: {this.tipo}");
            return sb.ToString();
        }

        public override int ServirMedida()
        {
            int retorno = 0;
            if (MEDIDA <= contenidoML)
            {
                contenidoML -= (MEDIDA * 8/10);
                retorno = MEDIDA * 8/10;
            }
            else if (MEDIDA > contenidoML)
            {
                retorno = contenidoML;
                contenidoML = 0;
            }
            return retorno;
        }

        public static implicit operator Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
