using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
           : this(mensaje, clase, metodo, null)
        {

        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public override string ToString()
        {
            string stackTraceTotal = string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{string.Format("Excepción en el método {0} de la clase {1} ", this.NombreMetodo, this.NombreClase)}");
            sb.AppendLine($"{base.Message}");
            Exception e = base.InnerException;
            while(e != null)
            {
                sb.AppendLine($"\t{e}");
                stackTraceTotal += e.StackTrace.ToString() + "\n";
                e = e.InnerException;
            }
            return sb.ToString();
        }
    }
}
