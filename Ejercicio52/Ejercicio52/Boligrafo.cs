using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colortinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colortinta = color;
            this.tinta = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.tinta -= 0.3f * texto.Length;
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.colortinta;
            }
            set
            {
                this.colortinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Es un Boligrafo");
            sb.AppendLine($"El color es: {this.Color}");
            sb.AppendLine($"El nivel de tinta es: {this.UnidadesDeEscritura}");
            return sb.ToString(); 
        }
    }
}
