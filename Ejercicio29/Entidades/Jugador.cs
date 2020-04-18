using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        int dni;
        public string nombre;
        int partidosJugados;
        float promedioGoles;
        int totalGoles;

        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre)
            :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int promedioGoles, int totalGoles)
            :this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.promedioGoles = GetPromediogoles();
            this.totalGoles = totalGoles;
        }

        public float GetPromediogoles()
        {
            return this.totalGoles / (float)this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\nDNI: {1}\nPartidos Jugados: {2}\nPromedio de goles: {3}\nTotal de goles: {4}\n", nombre, dni, partidosJugados, GetPromediogoles(), totalGoles);
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
