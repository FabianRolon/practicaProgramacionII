using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double arista)
        {
            return arista * arista;
        }

        public static double CalcularTriangulo(double arista, double altura)
        {
            return (arista * altura)/2;
        }

        public static double CalcularCirculo(double radio)
        {
            return 3.14 * radio * radio;
        }
    }
}
