using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Cubo
    {
        public static bool potenciaCubo(double numero, out double potencia)
        {
            potencia = 0;
            if (numero > 0)
            {
                potencia = Math.Pow(numero, 3);
                return true;
            }
            else
                return false;
        }
    }
}