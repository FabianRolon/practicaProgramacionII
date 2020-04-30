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
                return capacidadML * 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return contenidoML * 1000;
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
                return Contenido * (1/100);
            }
        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Capacidad: {this.CapacidadLitros}");
            sb.AppendLine($"Contenido: {this.Contenido}");
            return sb.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return GenerarInforme(); 
        }
    }
}
