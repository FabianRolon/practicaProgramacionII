using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia
        {
            get
            {
                return añosExperiencia;
            }

            set
            {
                añosExperiencia = value;
            }
        }

        public override string Mostrar()
        {
            return base.Mostrar() + "Años Experiencia:" + this.AñosExperiencia.ToString();
        }

        public override bool ValidarAptitud()
        {
            if(this.añosExperiencia >= 2 && Edad <= 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
