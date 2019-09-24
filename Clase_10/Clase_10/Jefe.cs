using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    class Jefe : Empleado
    {
        int bono;

        public Jefe(string nombre, int cuil, float sueldo, int bono)
            :base(nombre, cuil, sueldo)
        {
            this.bono = bono;
        }
    }
}
