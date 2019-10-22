using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsolaClase17
{
    class Program
    {
        static void Main(string[] args)
        {
            Estanteria<Ferreteria> e1 = new Estanteria<Ferreteria>(3);
            Estanteria<Producto> e2 = new Estanteria<Producto>(3);
            Estanteria<Alimenticio> e3 = new Estanteria<Alimenticio>(3);

            Alimenticio alimento1 = new Alimenticio(1, "arroz", new DateTime(2020, 05, 07));
            Alimenticio alimento2 = new Alimenticio(2, "fideos", new DateTime(2022, 10, 23));
            Ferreteria ferrete1 = new Ferreteria(3, "pinza", 35.6f);
            Ferreteria ferrete2 = new Ferreteria(4, "clavos", 1.5f);

            bool b1 = e3 + alimento1;
            bool b2 = e3 + alimento2;
            bool b3 = e1 + ferrete1;
            bool b4 = e1 + ferrete2;
        }
    }
}
