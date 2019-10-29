using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase21
{
    interface Imensaje
    {
        string Usuario
        {
            get;
            set;
        }

        string Texto
        {
            get;
            set;
        }

        DateTime Hora
        {
            get;
            set;
        }
    }
}
