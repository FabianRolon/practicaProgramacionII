using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicio_Clase_08
{
    public enum EPuestoJerarquico
    {
        Administración,
        Gerencia,
        Sistemas,
        Accionista
    }

    public class Empleado
    {
        string nombre;
        string apellido;
        string legajo;
        int salario;
        EPuestoJerarquico puesto;

        public Empleado(string nombre, string apellido, string legajo, int salario, EPuestoJerarquico puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.salario = salario;
            this.puesto = puesto;
        }

        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            if (emp1.legajo == emp2.legajo)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}\n Apellido: {1}\n Legajo: {2}\n Salario: {3}\n Puesto: {4}\n", this.nombre, this.apellido, this.legajo, this.salario, this.puesto);
            return str.ToString();
        }
    }
    
}
