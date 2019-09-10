using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            switch (operador)
            {
                case "+":
                    return "+";
                case "-":
                    return "-";
                case "*":
                    return "*";
                case "/":
                    return "/";
                default:
                    return "+";
            }
        }

        public static double Operar(Numero numeroUno, Numero NumeroDos, string operador)
        {
            switch (Calculadora.ValidarOperador(operador))
            {
                case "+":
                    return numeroUno + NumeroDos;
                case "-":
                    return numeroUno - NumeroDos;
                case "*":
                    return numeroUno * NumeroDos;
                case "/":
                    return numeroUno / NumeroDos;
                default:
                    return double.MinValue;
            }
        }
    }
}
