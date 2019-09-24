using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    public class Empleado : Persona
    {

        public float Sueldo { get; set; }

        public enum ETipoEmpleado
        {
            Empleado,
            Jefe,
            Vendedor
        }

        public Empleado(string nombre, int cuil, float sueldo)
            :base(nombre, cuil)
        {
            this.Sueldo = sueldo;
        }

        public override string Mostrar()
        {
            return this.Nombre + this.Cuil + this.Sueldo.ToString();
        }

        public void Aumentar(float porcentaje)
        {
            this.Sueldo = this.Sueldo * porcentaje;
        }
    }
}
