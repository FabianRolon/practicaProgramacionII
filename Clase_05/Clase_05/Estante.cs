using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    public class Estante
    {
        int ubicacionEstante;
        Producto[] productos;

        Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
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

        public string MostrarEstante(Estante estante)
        {

            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("Ubicacion del estante: {0}", estante.ubicacionEstante);

            foreach (Producto producto in estante.productos)
            {
                builder.AppendLine(Producto.MostrarProducto(producto));
            }

            return builder.ToString();
        }

        public static bool operator ==(Estante estante, Producto producto)
        {
            if (estante != null && !(producto is null))
                foreach (Producto productoAux in estante.productos)
                {
                    if (productoAux == producto)
                        return true;
                }
            return false;
        }
        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            if (estante != producto)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos is null)
                    {
                        estante.productos[i] = producto;
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
