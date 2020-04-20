using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas;

namespace TestConsolaEjercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 21";
            Fahrenheit d = new Fahrenheit(1);
            Kelvin p = new Kelvin(255.928);
            Celsius e = new Celsius(-17.2222);
            Console.WriteLine(((Fahrenheit)p).GetTemperatura());
            Console.WriteLine(((Fahrenheit)e).GetTemperatura());
            Console.WriteLine(((Celsius)d).GetTemperatura());
            Console.WriteLine(((Celsius)p).GetTemperatura());
            Kelvin resKelvin = p + d;
            Fahrenheit resFahrenheit = d + p;
            Celsius resCelsius = e + p;
            Console.WriteLine("Resultado Fahrenheit {0}", resFahrenheit.GetTemperatura());
            Console.WriteLine("Resultado Celsius {0}", resCelsius.GetTemperatura());
            Console.WriteLine("Resultado Kelvin {0}", resKelvin.GetTemperatura());
            Console.ReadKey();
        }
    }
}
