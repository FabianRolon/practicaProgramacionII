using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    class PuestoAtencion
    {
        static int numeroActual;
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        Puesto puesto;

        PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public int Numeroactual
        {
            get
            {
                return numeroActual++;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
        }
    }
}
