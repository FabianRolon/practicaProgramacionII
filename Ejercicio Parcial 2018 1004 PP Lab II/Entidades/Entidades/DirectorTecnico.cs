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

        public DirectorTecnico(string apellido, int dni, int edad, string nombre, int añosExperiencia) : base(apellido, dni, edad, nombre)
        {
            añosExperiencia = AñosExperiencia;
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
            if(añosExperiencia >= 2 && Edad <= 65)
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
