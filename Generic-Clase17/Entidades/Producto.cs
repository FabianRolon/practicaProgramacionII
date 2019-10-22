using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract public class Producto
    {
        int idProd;
        string descripcion;

        public Producto(int idProd, string descripcion)
        {
            this.idProd = idProd;
            this.descripcion = descripcion;
        }

        public int IdProduc
        {
            get
            {
                return idProd;
            }
        }

        public string Descripcion
        {
            get {
                return descripcion;
            }
        }

    }
}
