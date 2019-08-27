using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    public class Cuadrado //static significa que solo va a haber un solo objeto
    {
        

        public static bool potenciaCuadrado(double numero, out double potencia )
        {
            potencia = 0;
            if(numero > 0)
            {
                potencia = Math.Pow(numero, 2);
                return true;
            }
            else
                return false;
        }
    }
}
