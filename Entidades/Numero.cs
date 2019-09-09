using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        #region Constructores
        double numero;

        public Numero()
        {
            numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.numero = double.Parse(strNumero);
        }
        #endregion
        #region Set y Validar
        private double ValidarNumero(string strNumero)
        {
            double auxNumero;
            if (double.TryParse(strNumero, out auxNumero))
            {
                return auxNumero;
            }
            else
                return 0;
        }

        #endregion
        #region Operadores
        public static double operator +(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero + numeroDos.numero;
        }

        public static double operator -(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero - numeroDos.numero;
        }

        public static double operator *(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero * numeroDos.numero;
        }

        public static double operator /(Numero numeroUno, Numero numeroDos)
        {
            if (numeroDos.numero != 0)
            {
                return numeroUno.numero / numeroDos.numero;
            }
            else
                return double.MinValue;
        }
        #endregion
        #region Conversores
        public string DecimalBinario(string numero)
        {
            return Convert.ToByte(numero).ToString();
        }
        public string DecimalBinario()
        {
            double numero = this.numero;

            if (numero > 0 && numero % 2 == 0)
            {
                string resultado = "";
                do
                {
                    resultado = (numero % 2) + resultado;
                    numero = (int)numero / 2;
                } while (numero > 0);
                return resultado;
            }
            else
                return "Valor inválido";
        }

        public string BinarioDecimal()
        {
            string numero = this.numero.ToString();
            if (this.numero > 0)
            {
                return Convert.ToInt64(numero, 2).ToString();
            }
            else
                return "Valor invalido";
        }
        #endregion

        public string SetNumero
        {
            set { numero = ValidarNumero(value); }
        }


    }
}
