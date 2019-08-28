using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Alumno
    {
        int nota1;
        int nota2;
        double notaFinal;
        string apellido;
        int legajo;
        string nombre;
           
        public Alumno(string apellido, int legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
    }
}
