﻿using System;
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

        /// <summary>
        /// Genera una instancia del tipo Numero con valor "cero".
        /// </summary>
        public Numero()
        {
            numero = 0;
        }
        /// <summary>
        /// Inicializa una instancia del tipo Numero ingresando un numero de tipo 'double' sin validar.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Inicializa una instancia del tipo Numero ingresando un 'string' dentro se valida que sea un valor correcto.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        #endregion
        #region Set y Validaciones
        /// <summary>
        /// Propiedad que inicializa un objeto del tipo Numero validando que sea correcto.
        /// </summary>
        public string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }
        /// <summary>
        /// Metodo de clase que valida un dato del tipo 'string' se pueda convertir en un dato del tipo 'double' correcto.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna el resultado si sale bien, 0 caso contrario</returns>
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
        /// <summary>
        /// Metodo que valida si un dato del tipo 'string' sea un binario. 
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Valida si es binario o no, retorna true si es, false caso contrario</returns>
        public bool ValidarBinario(string strNumero)
        {
            for (int i = 0; i < strNumero.Length; i++)
            {
                if(strNumero[i] != '0' && strNumero[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
        #region Operadores
        /// <summary>
        /// Metodo estático de sobrecarga del operador 'suma' que suma los atributos numero entre dos objetos del tipo Numero.
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>Retorna la suma de los atributos de ambas instancias</returns>
        public static double operator +(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero + numeroDos.numero;
        }
        /// <summary>
        /// Metodo estático de sobrecarga del operador 'resta' que resta los atributos numero entre dos objetos del tipo Numero.
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>Retorna la resta de los atributos de ambas instancias</returns>
        public static double operator -(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero - numeroDos.numero;
        }
        /// <summary>
        /// Metodo estático de sobrecarga del operador 'multiplicar' que multiplica los atributos numero entre dos objetos del tipo Numero.
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>Retorna la multiplicacion de los atributos de ambas instancias</returns>
        public static double operator *(Numero numeroUno, Numero numeroDos)
        {
            return numeroUno.numero * numeroDos.numero;
        }
        /// <summary>
        /// Metodo estático de sobrecarga del operador 'division' que divide los atributos numero entre dos objetos del tipo Numero.
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>Retorna la division de los atributos de ambas instancias caso que el denominador sea cero retorna MinValue</returns>
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
        /// <summary>
        /// Convierte un dato del tipo string a un string en decimal.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el resultado si sale bien y "Valor Inválido" si no puede convertir</returns>
        public string DecimalBinario(string numero)
        {
            if(!double.TryParse(numero, out double auxNumero))
                return "Valor inválido";

            if (DecimalBinario(auxNumero) == -1)
            {
                return "Valor inválido";
            }
            else
                return DecimalBinario(auxNumero).ToString();
        }
        /// <summary>
        /// Convierte el atributo numero del tipo double de un objeto de tipo Numero en string binario.
        /// </summary>
        /// <returns>Retorna el resultado convertido o "-1" si no se puede convertir</returns>
        public double DecimalBinario(double numero)
        {
            if (numero > 0 && numero < 256)
            {
                string resultado = "";
                do
                {
                    resultado = (numero % 2) + resultado;
                    numero = (int)numero / 2;
                } while (numero > 0);
                return double.Parse(resultado);
            }
            else
                return -1;
        }
        /// <summary>
        /// Convierte el atributo numero del tipo string de un objeto de tipo Numero en binario.
        /// </summary>
        /// <returns>Retorna el resultado si sale bien y "Valor Inválido" si no puede convertir</returns>
        public string BinarioDecimal()
        {
            string bufferNumero = this.numero.ToString();
            if (ValidarBinario(bufferNumero))
            {
                double resultado = 0;
                for (int i = 0; i < bufferNumero.Length; i++)
                {
                    resultado += int.Parse(bufferNumero[i].ToString()) * (Math.Pow(2, bufferNumero.Length - 1 - i));
                }
                return resultado.ToString();
            }
            else
                return "Valor inválido";
        }
        #endregion
    }
}
