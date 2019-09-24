using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{

    public class Vendedor : Empleado
    {
        public int Objetivo { get; set; }

        public Vendedor(string nombre, int cuil, float sueldo, int objetivo)
            :base(nombre, cuil, sueldo)
        {
            this.Objetivo = objetivo;
        }

    }
}
