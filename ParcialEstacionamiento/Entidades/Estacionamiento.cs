using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible)
            : this()
        {
            this.espacioDisponible = espacioDisponible;
            this.nombre = nombre;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estacionamiento: {e.nombre}");
            sb.AppendLine($"Espacio disponilbe: {e.espacioDisponible}");
            sb.AppendLine($"Vehiculos ingresados:");
            foreach (Vehiculo vehiculo in e.vehiculos)
            {
                sb.AppendLine($"{vehiculo.ConsultarDatos()}");
                sb.AppendLine($"--------------------------");
            }
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in estacionamiento.vehiculos)
            {
                if (v == vehiculo)
                    return true;    
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(vehiculo.Patente != "" && estacionamiento != vehiculo && estacionamiento.vehiculos.Count < estacionamiento.espacioDisponible)
            {
                estacionamiento.vehiculos.Add(vehiculo);
            }
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                return vehiculo.ImprimirTicket();
            }
            else
            {
                return "El vehiculo no es parte del estacionamiento";
            }
        }
    }
}
