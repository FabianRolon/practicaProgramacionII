using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Pesos
    {
        double cantidad;
        static double cotizRespectoDolar = 55.93;

        Pesos(){}
        Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        Pesos(double cantidad, double cotizacion) 
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        
        
    }
}
