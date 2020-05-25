using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class OtraClase
    {
        int a;

        public void UnMetodoDeInstancia()
        {
            try
            {
                MiClase otraClase = new MiClase(1);
            }
            catch (UnaExepcion ex)
            {
                throw new MiExcepcion("Mensaje MiExcepcion", ex);
            }
        }
    }
}
