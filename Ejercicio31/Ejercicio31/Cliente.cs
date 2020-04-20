using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
#pragma warning disable CS0660, CS0661
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        public Cliente(string nombre, int numero)
            :this(nombre)
        {
            this.numero = numero;
        } 

        public string Nombre
        {
            get 
            { 
                return this.nombre; 
            }
            set 
            { 
                this.nombre = value; 
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Nombre == c2.Nombre;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
