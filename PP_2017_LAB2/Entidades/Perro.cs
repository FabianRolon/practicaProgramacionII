using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza)
            :base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            :this(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if (esAlfa)
            {
                sb.AppendLine($"{this.Datoscompletos()}, alfa de la manada, edad {this.Edad}");
            }
            else
            {
                sb.AppendLine($"{this.Datoscompletos()} edad {this.Edad}");
            }

            return sb.ToString();
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            return j1.Nombre == j2.Nombre && j1.Edad == j2.Edad && j1.Raza == j2.Raza;
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad; 
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return this == (Perro)obj; ;
        }
    }
}
