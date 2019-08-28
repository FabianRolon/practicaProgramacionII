using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public static class Calculadora
    {
        public static double Calcular(double primerNumero, double segundoNumero, char operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;
                case '/':
                    if(Calculadora.Validar(segundoNumero))
                        resultado = primerNumero / segundoNumero;
                    break;
            }
            return resultado;
        }

        static bool Validar(double segundoNumero)
        {
            if(segundoNumero != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
