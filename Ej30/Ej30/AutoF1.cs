using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej30
{
#pragma warning disable CS0660, CS0661
    public class AutoF1
    {
        private short cantidadDeCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.CantidadDeCombustible = 0;
            this.EnCompetencia = false;
            this.VueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short CantidadDeCombustible
        {
            get
            {
                return cantidadDeCombustible;
            }
            set
            {
                cantidadDeCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return enCompetencia;
            }
            set
            {
                enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return vueltasRestantes;
            }
            set
            {
                vueltasRestantes = value;
            }
        }

        public string Mostrardatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"En competencia: {this.EnCompetencia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");
            sb.AppendLine($"Cantidad de combustible: {this.CantidadDeCombustible}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero || a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
