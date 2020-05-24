using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Cartuchera1
    {
        private List<IAcciones> acciones;

        public Cartuchera1()
        {
            acciones = new List<IAcciones>();
        }

        public List<IAcciones> Lista
        {
            get
            {
                return this.acciones;
            }
        }
        public bool ProbarElementos()
        {
            bool retorno = true;
            foreach (IAcciones acc in acciones)
            {
                if(acc is Lapiz)
                {
                    acc.Escribir(" ");
                }
                else if(acc is Boligrafo)
                {                    
                    if (!(acc.Escribir(" ") is null))
                    {
                        acc.Escribir(" ");
                        Console.WriteLine($"{acc.UnidadesDeEscritura}");
                    }
                    else
                    {
                        acc.Recargar(1);
                        retorno = false;
                    }
                }
            }
            return retorno;
        }
    }
}
