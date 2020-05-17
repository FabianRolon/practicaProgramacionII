using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoDeCarrera
    {
        private short cantidadCombistible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short CantidadCombustible
        {
            get
            {
                return cantidadCombistible;
            }
            set
            {
                this.cantidadCombistible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");
            sb.AppendLine($"Esta en competencia: {this.EnCompetencia}");
            sb.AppendLine($"Escuderia: {this.Escuderia}");
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Vueltas Restantes: {this.VueltasRestantes}");
            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return v1.escuderia == v2.escuderia && v1.numero == v2.numero;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
