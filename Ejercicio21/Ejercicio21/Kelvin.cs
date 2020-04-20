using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        double temperatura;
        static double conversionRespectoFahrenheit;

        Kelvin()
        {
            conversionRespectoFahrenheit = 255.928;
        }
        public Kelvin(double temperatura)
            :this()
        {
            this.temperatura = temperatura;
        }

        public Kelvin(double temperatura, double conversion)
            : this(temperatura)
        {
            Kelvin.conversionRespectoFahrenheit = conversion;
        }

        public static void SetConversion(string valor)
        {
            if (!double.TryParse(valor, out double auxValor))
            {
            }
            else
                Kelvin.conversionRespectoFahrenheit = auxValor;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }
        public static double GetConversion()
        {
            return Kelvin.conversionRespectoFahrenheit;
        }
        #region Conversiones
        public static explicit operator Fahrenheit(Kelvin pesos)
        {
            return new Fahrenheit(pesos.temperatura / Kelvin.conversionRespectoFahrenheit);
        }

        public static explicit operator Celsius(Kelvin kelvin)
        {
            return (Celsius)((Fahrenheit)(kelvin.temperatura));
        }

        public static implicit operator Kelvin(double pesos)
        {
            return new Kelvin(pesos);
        }
        #endregion

        public static Kelvin operator +(Kelvin kelvin, Fahrenheit fahrenheit)
        {

            return new Kelvin(kelvin.temperatura + ((Kelvin)fahrenheit).temperatura);
        }

        public static Kelvin operator -(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            return new Kelvin(kelvin.temperatura - ((Kelvin)fahrenheit).temperatura);
        }

        public static Kelvin operator +(Kelvin kelvin, Celsius celsius)
        {
            return new Kelvin(kelvin.temperatura + ((Kelvin)celsius).temperatura);
        }

        public static Kelvin operator -(Kelvin kelvin, Celsius celsius)
        {
            return new Kelvin(kelvin.temperatura - ((Kelvin)celsius).temperatura);
        }

        public static bool operator ==(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            if (kelvin.temperatura == ((Kelvin)fahrenheit).GetTemperatura())
            {
                return true; 
            }
            else
                return false;
        }

        public static bool operator !=(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            return !(kelvin == fahrenheit);
        }

        public static bool operator ==(Kelvin kelvin, Celsius celsius)
        {
            if (kelvin.temperatura == ((Kelvin)celsius).GetTemperatura())
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Kelvin kelvin, Celsius celsius)
        {
            return !(kelvin == celsius);
        }

        public static bool operator ==(Kelvin kelvin1, Kelvin kelvin2)
        {
            if (kelvin1.temperatura == kelvin2.temperatura)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Kelvin kelvin1, Kelvin kelvin2)
        {
            return !(kelvin1 == kelvin2);
        }


    }

}
