using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Ingrediente
    {
        private int cantidad;
        private string descripcion;
        /// <summary>
        /// Contructor publico que recibe los parametros
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="descripcion"></param>
        public Ingrediente(int cantidad, string descripcion)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }
        /// <summary>
        /// Propiedad solo lectura que devuelve la cantidad
        /// </summary>
        public int Cantidad
        {
            get
            { 
                return this.cantidad;
            }
        }
        /// <summary>
        /// Propiedad abstracta  solo lectura que devuelve la descripcion del proceso de cada ingrediente
        /// </summary>
        public abstract string Proceso
        {
            get;
        }
        /// <summary>
        /// Propiedad abstracta solo lectura que devuelve la unidad de medida de cada ingrediente
        /// </summary>
        public abstract string UnidadDeMedida
        {
            get;
        }
        /// <summary>
        /// Metodo virtual que muestra la informacion del ingrediente
        /// </summary>
        /// <returns>Retorna un string con la info</returns>
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.descripcion} en una cantidad de {this.cantidad} {this.UnidadDeMedida}");
            sb.AppendLine(String.Format($"Procesar {this.Proceso}"));
            return sb.ToString();
        }
    }
}
