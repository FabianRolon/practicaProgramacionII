using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ferreteria : Producto
    {
        float peso;

        public Ferreteria(int idProduc, string descripcion, float peso)
           : base(idProduc, descripcion)
        {
            this.peso = peso;
        }

        public float Peso
        {
            get
            {
                return peso;
            }
        }

    }
}
