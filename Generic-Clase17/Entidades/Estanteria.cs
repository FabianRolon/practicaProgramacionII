using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estanteria <T> where T : Producto 
    {
        int tamano;
        T[] productos;

        public Estanteria(int tamano)
        {
            this.tamano = tamano;
            productos = new T[tamano];
        }

        public static bool operator +(Estanteria<T> estante, T producto)
        {
            foreach (T prod in estante.productos)
            {
                if(prod == producto)
                {
                    return false;
                }
            }

            for (int i = 0; i < estante.productos.Length; i++)
            {
                if(estante.productos[i] == null)
                {
                    estante.productos[i] = producto;
                    return true;
                }
            }
            return false;
        }

        public static bool operator -(Estanteria<T> estante, T producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    estante.productos[i] = null;
                    return true;
                }
            }
            return false;
        }
    }
}
