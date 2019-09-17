using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicio_Clase_08
{
    public class Empresa
    {
        List <Empleado> nominaEmpleados;
        string razonSocial;
        string direccion;
        float ganancias;

        public Empresa()
        {
            this.nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial, string direccion, float ganancias)
            : this()
        {
            this.razonSocial = razonSocial;
            this.direccion = direccion;
            this.ganancias = ganancias;
        }

        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            foreach (Empleado auxEmpleado in empresa.nominaEmpleados)
            {
                if(empleado == auxEmpleado)
                {
                    return empresa;
                }
            }
            empresa.nominaEmpleados.Add(empleado);
            return empresa;
        }

        public string MostrarEmpresa()
        {
            StringBuilder strEmpresa = new StringBuilder();
            strEmpresa.AppendFormat(" La empresa {0} sita en la calle {1} cuenta con ganancias por {2} y con {3} empleados:", this.razonSocial, this.direccion, this.ganancias, this.nominaEmpleados.Count);
            return strEmpresa.ToString();
        }
    }
}
