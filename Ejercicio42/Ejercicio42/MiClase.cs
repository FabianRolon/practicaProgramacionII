using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiClase
    {
        int a;
        public MiClase()
        {
            try
            {
                MetodoDivision();
            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException("Mensaje DivideByZero", ex);
            }
        }
        public MiClase(int a)
        {
            this.a = a;
            try
            {
                MiClase nuevaClase = new MiClase();
            }
            catch(DivideByZeroException ex)
            {
                throw new UnaExepcion("Mensaje UnaExecion", ex);
            }

        }
        public static void MetodoDivision()
        {
            throw new DivideByZeroException();
        }
    }
}
