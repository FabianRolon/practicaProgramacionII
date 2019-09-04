using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    public class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;

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

        public static string MostrarProducto(Producto producto)
        {
            return string.Format("Codigo de barras: {0}\n Marca: {1}\n Precio: {2}", producto.codigoDeBarra, producto.marca, producto.precio);
        }

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            return (productoDos.marca == productoUno.marca && productoUno.codigoDeBarra == productoDos.codigoDeBarra);
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }

        public static bool operator ==(Producto producto, string marca)
        {
            return producto.marca == marca;
        }

        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto.marca == marca);
        }
        


    }
}
