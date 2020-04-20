using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
#pragma warning disable CS0660, CS0661
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        
        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue(); 
            }
            set
            {
                _ = this + value;
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        public static bool operator +(Negocio n, Cliente c)
        {         
            foreach (Cliente cliente in n.clientes)
            {
                if(cliente == c)
                {
                    return false;
                }
            }
            n.clientes.Enqueue(c);
            
            return true;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
    }
}
