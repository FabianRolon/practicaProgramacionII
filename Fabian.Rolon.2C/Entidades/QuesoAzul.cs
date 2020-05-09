using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class QuesoAzul : Ingrediente
    {
        /// <summary>
        /// Enumerado con la lista de posibles procedencias del queso azul
        /// </summary>
        public enum Procedencia
        {
            Francia,
            Argentina,
            Italia
        }

        Procedencia procedencia;
        /// <summary>
        /// Constructor con dos parametros de la clase QuesoAzul
        /// </summary>
        /// <param name="descripcion">Descripcion del proceso</param>
        /// <param name="cantidad">Cantidad de queso azul</param>
        public QuesoAzul(string descripcion, int cantidad)
            :base(cantidad, descripcion)
        {

        }
        /// <summary>
        ///  Constructor con tres parametros de la clase QuesoAzul
        /// </summary>
        /// <param name="descripcion">Descripcion del proceso</param>
        /// <param name="cantidad">Cantidad de queso azul</param>
        /// <param name="procedencia">Se define la procedencia de la lista enumerada</param>
        public QuesoAzul(string descripcion, int cantidad, Procedencia procedencia)
            : this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }
        /// <summary>
        /// Sobreescritura de la propiedad Proceso del queso azul, devuelve "desgranar"
        /// </summary>
        public override string Proceso
        {
            get
            {
                return "desgranar";
            }
        }
        /// <summary>
        /// Sobreescritura de la propiedad Proceso del queso azul, devuelve la unidad de medidad
        /// </summary>
        public override string UnidadDeMedida
        {
            get
            {
                return "gramos";
            }
        }
        /// <summary>
        /// Metodo sobreescrito que devuelve la informacion de la instacia del queso azul
        /// </summary>
        /// <returns></returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Informacion()}");
            sb.AppendLine(String.Format($"Procedente de: {this.procedencia}"));
            return sb.ToString();
        }

    }
}
