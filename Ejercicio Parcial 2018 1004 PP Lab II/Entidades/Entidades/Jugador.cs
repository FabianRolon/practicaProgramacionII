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

        public Jugador(string apellido, int dni, int edad, string nombre, float altura, float peso, Posicion posicion) :base(apellido, dni, edad, nombre)
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
            str.AppendFormat("Altura: {0}\n Peso: {1}\n Posicion: {2}\n", Altura, Peso, Posicion);
            return base.Mostrar() + str.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            float imc = Peso / Altura * Altura;
            if (imc >= 18.5 && imc <= 25)
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
