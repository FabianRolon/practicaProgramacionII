using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Jefe : Empleado
    {
        public int Bono { get; set; }

        public Jefe(string nombre, int cuil, float sueldo, int bono)
            :base(nombre, cuil, sueldo)
        {
            this.Bono = bono;
        }


    }
}
