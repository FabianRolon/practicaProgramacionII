using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace otraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(2, 40, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(44, "KTM");
            bool pudo = competencia + motoCross;
        }
    }
}
