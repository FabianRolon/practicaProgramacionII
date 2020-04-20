using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31
{
    public enum Puesto
    {
        Caja1, Caja2
    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        Puesto puesto;

        public PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
            :this()
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(5000);
            return true;
        }

    }
}
