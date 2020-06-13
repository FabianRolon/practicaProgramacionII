using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Ejercicio40_CentralitaPoli;
using LoremNET;

namespace MainConHilos
{
    public class Generar
    {
        Centralita c;
        public Generar (Centralita centralita)
        {
            this.c = centralita;
        }
        Random aleatorio = new Random();
        public void GenerarLlamada()
        {
            while (true)
            {
                int nro = aleatorio.Next(0, 6);
                int aleatorioDuracion = aleatorio.Next(1, 5);
                float duracion = (float)(aleatorioDuracion / aleatorio.NextDouble());
                float costo = (float)(nro * aleatorio.NextDouble());
                if (nro <= 3)
                {
                    string origen = Lorem.Words(1, true);
                    string destino = Lorem.Words(1, true);
                    Local llamadaLocal = new Local(origen, duracion, destino, costo);
                    c += llamadaLocal;
                }
                else
                {
                    Provincial.Franja franja;
                    string origen = Lorem.Words(1, true);
                    string destino = Lorem.Words(1, true);
                    int nroFranja = aleatorio.Next(0, 9);
                    if (nro < 3)
                    {
                        franja = Provincial.Franja.Franja_1;
                    }
                    else if (nro > 3 && nro < 6)
                    {
                        franja = Provincial.Franja.Franja_2;
                    }
                    else
                    {
                        franja = Provincial.Franja.Franja_3;
                    }

                    Provincial llamadaProvincial = new Provincial(origen, franja, duracion, destino);
                    c += llamadaProvincial;
                }
                Thread.Sleep(aleatorio.Next(500, 3000));
            }
        }
    }
}
