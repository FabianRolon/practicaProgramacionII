using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
         public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            if (this.tamanioMina >= 0.1f * texto.Length)
            {
                this.tamanioMina -= 0.1f * texto.Length;
                return new EscrituraWrapper(texto, this.Color);
            }
            return null;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Es un Lapiz");
            sb.AppendLine($"El color es: {this.Color}");
            sb.AppendLine($"El tamaño de mina es: {this.UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
