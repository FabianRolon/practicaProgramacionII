using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Cartuchera2
    {
        private List<Boligrafo> listaBoligrafos;
        private List<Lapiz> listaLapices;

        public Cartuchera2()
        {
            listaBoligrafos = new List<Boligrafo>();
            listaLapices = new List<Lapiz>();
        }

        public List<Boligrafo> ListaBoligrafos
        {
            get
            {
                return this.listaBoligrafos;
            }
        }
        public List<Lapiz> ListaLapices
        {
            get
            {
                return this.listaLapices;
            }
        }

        public bool ProbarElementos()
        {
            foreach (IAcciones acc in listaBoligrafos)
            {

                    if (!(acc.Escribir(" ") is null))
                    {
                        acc.Escribir(" ");
                        Console.WriteLine($"{acc.UnidadesDeEscritura}");
                    }
                    else
                    {
                        acc.Recargar(1);
                        return false;
                    }
            }
            foreach (IAcciones acc in listaLapices)
            {

                if (!(acc.Escribir(" ") is null))
                {
                    acc.Escribir(" ");
                    Console.WriteLine($"{acc.UnidadesDeEscritura}");
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
