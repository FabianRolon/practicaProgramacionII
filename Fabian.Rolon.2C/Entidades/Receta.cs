using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Receta
    {
        public enum Tipo
        {
            Clasica,
            Especial
        }

        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;
        /// <summary>
        /// Contructor privado que instancia la lista de ingredientes.
        /// </summary>
        private Receta()
        {
            ingredientes = new List<Ingrediente>();
        }
        /// <summary>
        /// Constructor estatico donde se inicia por defecto que la preparacion sera de tipo "Clasica".
        /// </summary>
        static Receta()
        {
            preparacion = Tipo.Clasica;
        }
        /// <summary>
        /// Contructor que recibe un parametro para dar el valor al atributo capacidad del contenedor
        /// </summary>
        /// <param name="capacidad">Capacidad del contenedor</param>
        public Receta(int capacidad)
            :this()
        {
            this.capacidadDelContenedor = capacidad;
        }

        public static Tipo Preparacion
        {
            set
            {
                preparacion = value;
            }
        }
        /// <summary>
        /// Retornará el total libre – la cantidad del ingrediente recibido como argumento.
        /// </summary>
        /// <param name="planta">Instancia del tipo Ingrediente</param>
        /// <returns>Retorna la capacidad restante del contenedor</returns>
        private int CapacidadLibre(Ingrediente planta)
        {
            return this.CapacidadLibre() - planta.Cantidad;
        }
        /// <summary>
        /// Metodo para saber cuanto espacio queda en el contenedor segun la lista de ingredientes.
        /// </summary>
        /// <returns>Retornará el espacio libre teniendo en cuenta los ingredientes de la Receta</returns>
        private int CapacidadLibre()
        {
            int capacidadAux = this.capacidadDelContenedor;
            if (!(ingredientes is null))
            {
                foreach (Ingrediente ingrediente in this.ingredientes)
                {
                    capacidadAux -= ingrediente.Cantidad;
                }
            }
            return capacidadAux;
        }
        /// <summary>
        /// Sobreacarga del operador + que agrega un ingrediente a la lista
        /// </summary>
        /// <param name="receta">una receta</param>
        /// <param name="ingrediente">Un ingrediente</param>
        /// <returns>Retorna true si agrega, false caso contrario</returns>
        public static bool operator +(Receta receta, Ingrediente ingrediente)
        {
            if(receta.CapacidadLibre(ingrediente) >= 0)
            {
                receta.ingredientes.Add(ingrediente);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sobrecarga del metodo ToString para mostrar la informacion completa de la receta
        /// </summary>
        /// <returns>Retorla un string con la info de la receta</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Receta: {Receta.preparacion}");
            sb.AppendLine($"Capacidad Libre: {this.CapacidadLibre()}");
            sb.AppendLine($"Capacidad Total: {this.capacidadDelContenedor}");
            sb.AppendLine($"Lista de ingredientes:\n");
            foreach (Ingrediente ingrediente in this.ingredientes)
            {
                sb.AppendLine($"{ingrediente.Informacion()}");
            }
            return sb.ToString(); 
        }
    }
}
