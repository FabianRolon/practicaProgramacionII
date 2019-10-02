using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura,  Posicion posicion) :base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public float Altura
        {
            get
            {
                return altura;
            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return posicion;
            }
        }

        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Altura: {0}\nPeso: {1}\nPosicion: {2}\n", Altura, Peso, Posicion);
            return base.Mostrar() + str.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            float imc;
            imc = ((float)peso / (altura * altura));
            if (imc >= 18.5 && imc <= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool ValidarAptitud()
        {
            if(Edad <= 40 && ValidarEstadoFisico())
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
