using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidad
{
    public delegate void EncargadotiempoEventHandler();
    public sealed class Temporizador
    {
        
        public event EncargadotiempoEventHandler EventoTiempo;

        private Thread hilo;
        private int intervalo;

        public int Intervalo
        {
            get
            {
                return intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
        public bool Activo
        {
            get
            {
                if(hilo != null)
                {
                    return hilo.IsAlive;
                }
                else
                {
                    return false;
                }      
            }
            set
            {
                if (value)
                {
                    if (Activo != true && hilo is null)
                    {
                        hilo = new Thread(Corriendo);
                        hilo.Start();
                    }

                }
                else
                {
                    if (Activo == true && !(hilo is null))
                        hilo.Abort();
                }
            }
        }
        private void Corriendo()
        {
            do
            {
                Thread.Sleep(intervalo);
                if (this.EventoTiempo != null)
                    this.EventoTiempo.Invoke(); 
            } while (true);
        }
    }
}
