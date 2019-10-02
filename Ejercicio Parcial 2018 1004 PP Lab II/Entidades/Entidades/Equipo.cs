using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                    directorTecnico = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("DATOS DE EQUIPO\n\n");
            str.AppendLine("Nombre de Equipo: " + e.Nombre + "\n");
            str.AppendLine("Director Tecnico\n");
            if (e.directorTecnico != null)
            {               
                str.AppendLine(e.directorTecnico.Mostrar());
            }
            else
            {
                str.AppendLine("Sin DT Asignado\n");
            }
            str.AppendLine("Lista de Jugadores\n");
            foreach (Jugador item in e.jugadores)
            {
                str.AppendLine(item.Mostrar());
            }
            return str.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach (Jugador item in e.jugadores)
            {
                if ((item != j))
                {
                    retorno = false;
                }
                else
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < Equipo.cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
                return e;
            }
            else
            {
                return e;
            }
        }

        public static bool ValidarEquipo(Equipo e)
        {
            int cantidadArqueros = 0;
            int cantidadDefensores = 0;
            int cantidadCentrales = 0;
            int cantidadDelanteros = 0;
            if (e.directorTecnico != null)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    switch (jugador.Posicion)
                    {
                        case Posicion.Arquero:
                            cantidadArqueros++;
                            break;
                        case Posicion.Defensor:
                            cantidadDefensores++;
                            break;
                        case Posicion.Central:
                            cantidadCentrales++;
                            break;
                        case Posicion.Delantero:
                            cantidadDelanteros++;
                            break;
                    }
                }
                if (e.jugadores.Count == cantidadMaximaJugadores)
                {
                    if (cantidadArqueros == 1 && cantidadCentrales > 0 && cantidadDefensores > 0 && cantidadDelanteros > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
