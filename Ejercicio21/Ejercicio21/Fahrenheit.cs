using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Fahrenheit
    {
        double temperatura;
        static double conversionRespectorFahreheit;

        Fahrenheit()
        {
            conversionRespectorFahreheit = 1;
        }
        public Fahrenheit(double temperatura)
            : this()
        {
            this.temperatura = temperatura;
        }

        public Fahrenheit(double temperatura, double conversionRespectorFahreheit)
            : this(temperatura)
        {
            Fahrenheit.conversionRespectorFahreheit = conversionRespectorFahreheit;
        }

        public static void SetTemperatura(string valor)
        {
            if (!double.TryParse(valor, out double auxValor))
            {
            }
            else
                Fahrenheit.conversionRespectorFahreheit = auxValor;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static double GetConversion()
        {
            return Fahrenheit.conversionRespectorFahreheit;
        }

        public static implicit operator Fahrenheit(double fahrenheit)
        {
            return new Fahrenheit(fahrenheit);
        }

        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            return new Kelvin((fahrenheit.temperatura + 459.67)* (5/9));
        }

        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            return new Celsius((fahrenheit.GetTemperatura() - 32) * (5/9));
        }
        public static Fahrenheit operator +(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            return new Fahrenheit(fahrenheit.temperatura + ((Fahrenheit)kelvin).temperatura);
        }

        public static Fahrenheit operator -(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            return new Fahrenheit(fahrenheit.temperatura - ((Fahrenheit)kelvin).temperatura);
        }
        public static Fahrenheit operator +(Fahrenheit fahrenheit, Celsius celsius)
        {
            return new Fahrenheit(fahrenheit.temperatura + ((Fahrenheit)celsius).temperatura);
        }

        public static Fahrenheit operator -(Fahrenheit fahrenheit, Celsius celsius)
        {
            return new Fahrenheit(fahrenheit.temperatura - ((Fahrenheit)celsius).temperatura);
        }

        public static bool operator ==(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            if (fahrenheit.temperatura == ((Fahrenheit)kelvin).GetTemperatura())
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            return !(fahrenheit == kelvin);
        }

        public static bool operator ==(Fahrenheit fahrenheit, Celsius celsius)
        {
            if (fahrenheit.temperatura == ((Fahrenheit)celsius).GetTemperatura())
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Fahrenheit fahrenheit, Celsius celsius)
        {
            return !(fahrenheit == celsius);
        }

        public static bool operator ==(Fahrenheit fahrenheit1, Fahrenheit farenheit2)
        {
            if (fahrenheit1.temperatura == farenheit2.GetTemperatura())
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            return !(fahrenheit1 == fahrenheit2);
        }


    }
}
