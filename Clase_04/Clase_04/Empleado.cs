using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Empleado
    {
        string nombre;
        string apellido;
        double sueldoBruto;
        double sueldoNeto;
        double jubilacion;
        double ley19032;
        double obraSocial;
        double sindicato;

        public Empleado(string nombre, string apellido, double sueldoBruto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBruto = sueldoBruto;
        }

        public Empleado(string nombre, string apellido, double sueldoBruto, double sueldoNeto, double jubilacion, double ley19032, double obraSocial)
            : this(nombre, apellido, sueldoBruto)
        {
            this.sueldoNeto = sueldoNeto;
            this.jubilacion = jubilacion;
            this.ley19032 = ley19032;
            this.obraSocial = obraSocial;
        }

        public void CalcularNeto()
        {
            this.jubilacion = this.sueldoBruto * 0.11;
            this.ley19032 = this.sueldoBruto * 0.03;
            this.obraSocial = this.sueldoBruto * 0.03;
            this.sueldoNeto = this.sueldoBruto - (this.jubilacion + this.ley19032 + this.obraSocial);
        }

        public void CalcularNeto(bool sindicato)
        {
            if (sindicato)
            {
                this.sindicato = this.sueldoBruto * 0.02;
                this.sueldoNeto = this.sueldoNeto - this.sindicato;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nSueldo Bruto: {2}\nSueldo Neto: {3}\nJubilacion: {4}\nLey 19032: {5}\nObra Social: {6}\nSindicato: {7}", nombre, apellido, sueldoBruto, sueldoNeto, jubilacion, ley19032, obraSocial, sindicato);
            Console.ReadKey();
        }

        public void Aumento(float valorAumento)
        {
            this.sueldoBruto = this.sueldoBruto + valorAumento;
            this.CalcularNeto();
        }

        public void Aumento(int valorAumento)
        {
            this.sueldoBruto += (this.sueldoBruto * valorAumento * 0.01);
            this.CalcularNeto();
        }

        public static Empleado operator +(Empleado empleado , float aumento)
        {
            empleado.Aumento(aumento);

            return empleado;
        }

    }
}
