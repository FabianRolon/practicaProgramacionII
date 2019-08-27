using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public static class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            bool flag = false;
            double resultado = numero;
            string binario = "";

            do
            {
                if(resultado % 2 == 0)
                {
                    binario += "1";
                }
                else
                {
                    binario += "0";
                }
                resultado = resultado / 2;
                if(resultado == 1)
                    flag = true;
            } while (!flag);
            return binario;
        }

        /*static double BinarioDecimal(string numero)
        {

        }*/
    }
}
