using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        double numero;

        public Numero()
        {
            numero = 0;
        }

        public Numero(double numero)
        {
            this.numero =  numero;
        }

        public Numero(string strNumero)
        {
            
        }

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

        public void SetNumero(string strNumero)
        {
            this.numero = ValidarNumero(strNumero);
        }
    }
}
