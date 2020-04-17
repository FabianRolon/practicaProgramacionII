using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre)
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool flag = true;
            if (e.jugadores.Count() < e.cantidadDeJugadores)
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador == j)
                    {
                        flag = false;
                        break;
                    }
                }
                e.jugadores.Add(j);
            }
            else
            {
                flag = false;
            }
            return flag;           
        }
    }
}
