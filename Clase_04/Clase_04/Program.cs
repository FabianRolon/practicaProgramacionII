using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleadoUno = new Empleado("Fabian", "Rolon", 50000);
            Empleado empleadoDos = new Empleado("Flor", "Peñaranda", 100000);
            empleadoUno.CalcularNeto();
            empleadoUno.CalcularNeto(true);
            empleadoUno.Aumento(5000f); //tengo que aclarar que tipo de dato de sobrecarga aplico, sino el compilador no sabe cual estoy usando (le puse f que indica que el parametro que ingreso es del tipo float)
            empleadoUno.Aumento(5); // por defecto me toma el parametro como int
            empleadoDos.CalcularNeto(false);
            empleadoDos.Aumento(13);
            empleadoDos.Mostrar();
            empleadoUno.Mostrar();
        }
    }
}
