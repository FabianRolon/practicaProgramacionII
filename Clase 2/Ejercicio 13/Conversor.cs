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
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                resultado =(int) resultado / 2;
                if(resultado == 1)
                {
                    binario = "1" + binario;
                    flag = true;
                }
            } while (!flag);
            return binario;
        }

        /*static double BinarioDecimal(string numero)
        {
            
        }*/

        public static double BinarioDecimalFacil(string num)
        {

            return Convert.ToInt64(num, 2);
        }

        public static string DecimalBinarioFacil(double num)
        {
            return Convert.ToString(Convert.ToByte(num), 2);
        }
    }
}
