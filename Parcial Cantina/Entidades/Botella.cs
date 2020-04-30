using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    

    public abstract class Botella
    {
        public enum Tipo
        {
            Vidrio,
            Plastico
        }

        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            if(capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.capacidadML = capacidadML;
            }
            this.contenidoML = contenidoML;
        }


        public int CapacidadLitros
        {
            get
            {
                return capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return contenidoML / 1000;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                float retorno = 0;
                retorno = this.Contenido * (this.capacidadML*(1 / 100));
                return retorno;
            }
        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Capacidad: {this.capacidadML} mL");
            sb.AppendLine($"Contenido: {this.contenidoML} mL");
            return sb.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return GenerarInforme(); 
        }
    }
}
