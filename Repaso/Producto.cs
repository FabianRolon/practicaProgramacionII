using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Precio: {0}\n Marca: {1}\n Codigo de barras: {2}", p.GetPrecio(), p.GetMarca(), p.codigoDeBarra);
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.GetMarca() == p2.GetMarca() && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string marca)
        {
            if(p1.GetMarca() == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
    }
}
