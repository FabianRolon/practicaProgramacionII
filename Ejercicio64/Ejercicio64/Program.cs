using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hilo1 = new Thread();
            hilo1.Name = "caja1"; 
            Thread hilo2 = new Thread();
            hilo2.Name
            Thread hilo3 = new Thread();
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);
            negocio.Clientes.Add("Sabina");
            negocio.Clientes.Add("Honoria");
            negocio.Clientes.Add("Tránsito");
            negocio.Clientes.Add("Higinio");
            negocio.Clientes.Add("Ufano");
            negocio.Clientes.Add("Hilario");
            negocio.Clientes.Add("Jacinta");
            negocio.Clientes.Add("Cándido");
            negocio.Clientes.Add("Teodosia");
            negocio.Clientes.Add("Cástulo");
            negocio.Clientes.Add("Gervasia");
            negocio.Clientes.Add("Epifanio");
            negocio.Clientes.Add("Eufemio");
            negocio.Clientes.Add("Eustaquio");
            negocio.Clientes.Add("Brígida");
            negocio.Clientes.Add("Melitón");
            negocio.Clientes.Add("Leonila");
            negocio.Clientes.Add("Nicanor");
            negocio.Clientes.Add("Martina");
            negocio.Clientes.Add("Régulo");
            negocio.Clientes.Add("Teodora");
            negocio.Clientes.Add("Teódulo");
            negocio.Clientes.Add("Tiburcio ");
            negocio.Clientes.Add("Celso");




        }
    }
}
