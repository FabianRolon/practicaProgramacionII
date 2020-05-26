using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    public class Recibo : Documento
    {
        public Recibo()
            :this(new int())
        {

        }
        public Recibo(int numero)
            :base(numero)
        {

        }

    }
}
