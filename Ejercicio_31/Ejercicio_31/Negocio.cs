using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Cliente Cliente
        {
            get
            {
                if (clientes.Count != 0)
                {
                    return clientes.Dequeue();
                }
                else
                    return null;

            }
            set
            {
                foreach (Cliente cliente in clientes)
                {
                    if (cliente == value)
                    {
                        break;
                    }
                }
                clientes.Enqueue(value);
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (c == cliente)
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

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            else
                return false;
        }

        public static bool operator ~(Negocio n)
        {
            PuestoAtencion puesto = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            if (puesto.Atender(n.Cliente))
            {
                return true;
            }
            else
                return false;
        }
    }
}
