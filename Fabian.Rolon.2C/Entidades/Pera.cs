using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pera : Ingrediente
    {
        private string tipo;
        /// <summary>
        /// Contructor de la clase Pera
        /// </summary>
        /// <param name="descripcion">Descripcion del ingrediente</param>
        /// <param name="cantidad">Cantidad en entero</param>
        /// <param name="tipo">Tipo del ingrediente Pera</param>
        public Pera(string descripcion, int cantidad, string tipo)
            :base(cantidad, descripcion)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Sobreescritura de la propiedad Proceso de la pera, devuelve "Cubitar"
        /// </summary>
        public override string Proceso
        {
            get
            {
                return "cubitar";
            }
        }
        /// <summary>
        /// Sobreescritura de la propiedad Proceso de la pera, devuelve la unidad de medidad
        /// </summary>
        public override string UnidadDeMedida
        {
            get
            {
                return "unidades";
            }
        }
        /// <summary>
        /// Sobreescirtura del metodo Informacion
        /// </summary>
        /// <returns>Retorna un string con los datos de la Pera</returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Informacion()}");
            sb.AppendLine(String.Format($"Tipo {this.tipo}"));
            return sb.ToString();
        }
    }
}
