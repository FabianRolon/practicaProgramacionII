using System;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace Entidades
{
    public abstract class Astro
    {
        
        protected int duraOrbita;
        protected int duracionRotacion;
        protected string nombre;
        AstroDelegate AstroEvent;
        Thread hiloOrbita;
        Thread hiloRotacion;
        

        public int DuraOrbita
        {
            get
            {
                return duraOrbita;
            }
            set
            {
                duraOrbita = value;
            }
        }

        public int DuraRotacion
        {
            get
            {
                return duracionRotacion;
            }
            set
            {
                duracionRotacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public Thread HiloOrbita
        {
            get
            {
                return hiloOrbita;
            }
            set
            {
                hiloOrbita = value;
            }
        }

        public Thread HiloRotacion
        {
          get
          {
            return hiloRotacion;
          }
          set
          {
            hiloRotacion = value;
          }
        }

    public Astro()
        {
        }

    public Astro(int duraOrbita, int duraRotacion, string nombre)
       :this()
        {
            this.duraOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

    public void InvocarEnvento()
    {
    }

        protected string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Nombre: {nombre}");
            retorno.AppendLine($"Duracion de la orbita: {duraOrbita}");
            retorno.AppendLine($"Duracion de la rotacion: {duracionRotacion}");
            return retorno.ToString();
        }
    }
}
