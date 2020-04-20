using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celsius
    {
        double temperatura;
        static double conversionRespectoFahrenheit;

        Celsius()
        {
            conversionRespectoFahrenheit = -17.22;
        }
        public Celsius(double temperatura)
            :this()
        {
            this.temperatura = temperatura;
        }

        public Celsius(double temperatura, double conversion)
            : this(temperatura)
        {
            Celsius.conversionRespectoFahrenheit = conversion;
        }

        public static void SetConversion(string valor)
        {
            if (!double.TryParse(valor, out double auxValor))
            {
            }
            else
                Celsius.conversionRespectoFahrenheit = auxValor;
        }

        public static double GetConversion()
        {
            return Celsius.conversionRespectoFahrenheit;
        }
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static implicit operator Celsius(double celcius)
        {
            return new Celsius(celcius);
        }

        public static explicit operator Kelvin(Celsius celcius)
        {
            Fahrenheit d1 = (Fahrenheit)celcius;
            Kelvin p1 =(Kelvin)(d1);
            return p1;
        }

        public static explicit operator Fahrenheit(Celsius celcius)
        {
            return new Fahrenheit(celcius.temperatura * (9/5) + 32);
        }
        public static Celsius operator +(Celsius celcius, Kelvin kelvin)
        {
            return new Celsius(celcius.temperatura + ((Celsius)kelvin).temperatura);
        }

        public static bool operator ==(Celsius c1, Celsius e2)
        {
            bool retorno = false;
            if (c1.GetTemperatura() == e2.GetTemperatura())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            bool retorno = false;
            if ((Kelvin)c == k)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            bool retorno = false;
            if ((Fahrenheit)c == f)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            Celsius retorno = new Celsius(c.temperatura - ((Celsius)k).temperatura);
            return retorno;
        }
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            Celsius retorno = new Celsius(c.temperatura + ((Celsius)f).temperatura);
            return retorno;
        }
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            Celsius retorno = new Celsius(c.temperatura - ((Celsius)f).temperatura);
            return retorno;
        }
    }
}
