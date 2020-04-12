using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Estante: {0}\n", e.ubicacionEstante);

            foreach (Producto p in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
                sb.AppendLine("-------------------------------------------");
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool flag = false;
            foreach (Producto producto in e.productos)
            {
                if (producto == p)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool flag = false;

            if (e == p)
            {
                return flag;
            }
            else
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        flag = true;
                    }
                }
                return flag;
            }
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                    }
                }
            }
            return e;
        }
    }
}
