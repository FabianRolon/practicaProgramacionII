using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimenticio : Producto
    {
        DateTime vencimiento;

        public Alimenticio(int idProduc,string descripcion, DateTime vencimiento)
            :base(idProduc, descripcion)
        {
            this.vencimiento = vencimiento;
        }

        public DateTime Vencimiento
        {
            get
            {
                return vencimiento;
            }
        }

    }
}
