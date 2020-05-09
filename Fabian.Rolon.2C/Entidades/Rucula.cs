using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rucula : Ingrediente
    {
        /// <summary>
        /// Constructor con parametros para la clase Rucula
        /// </summary>
        /// <param name="descripcion">Descripcion de la rucula</param>
        /// <param name="cantidad">Cantidad de rucula</param>
        public Rucula(string descripcion, int cantidad)
            :base(cantidad, descripcion)
        {

        }
        /// <summary>
        /// Sobreescritura de la propiedad Proceso de la Rucula, devuelve "Cortar"
        /// </summary>
        public override string Proceso
        {
            get
            {
                return "cortar";
            }
        }
        /// <summary>
        /// Sobreescritura de la propiedad Proceso de la Rucula, devuelve la unidad de medidad
        /// </summary>
        public override string UnidadDeMedida
        {
            get
            {
                return "hojas";
            }
        }
    }
}
