using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Negocio
    {
        private List<string> clientes;
        private Caja cajaUno;
        private Caja cajaDos;

        public Negocio(Caja c1, Caja c2)
        {
            this.cajaUno = c1;
            this.cajaDos = c2;
            clientes = new List<string>();
        }
        public List<string> Clientes
        {
            get
            {
                return clientes;
            }
        }
        public Caja CajaUno
        {
            get
            {
                return cajaUno;
            }
        }
        public Caja CajaDos
        {
            get
            {
                return cajaDos;
            }
        }
        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (string item in this.Clientes)
            {
                if (CajaUno.FilaClientes.Count <= CajaDos.FilaClientes.Count)
                { 
                    this.CajaUno.FilaClientes.Add(item); 
                }
                else if (CajaDos.FilaClientes.Count < CajaUno.FilaClientes.Count)
                    this.CajaDos.FilaClientes.Add(item);
                Thread.Sleep(1000);
            }
        }
    }
}
