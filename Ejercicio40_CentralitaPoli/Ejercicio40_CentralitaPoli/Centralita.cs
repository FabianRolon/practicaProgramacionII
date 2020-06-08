using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio40_CentralitaPoli
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLLamadas;
        protected string razonSocial;
        private string rutaDeArchivo;

        public Centralita()
        {
            listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreDeLaEmpresa)
            :this()
        {
            this.razonSocial = nombreDeLaEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPortotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLLamadas;
            }
        }

        public string RutaDeArchivo 
        {
            get
            {
                return this.rutaDeArchivo;     
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float totalLocal = 0;
            float totalProvincial = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                    totalLocal += ((Local)llamada).CostoLlamada;
                if (llamada is Provincial)
                    totalProvincial += ((Provincial)llamada).CostoLlamada;
            }
            
            switch (tipo)
            {
                case TipoLlamada.Local:
                    return totalLocal;
                case TipoLlamada.Provincial:
                    return totalProvincial;
                case TipoLlamada.Todas:
                    return totalLocal + totalProvincial;
                default:
                    return 0;
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciasPortotal}");
            sb.AppendLine($"Ganancia Local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciasPorProvincial}");
            sb.AppendLine($"Detalle de llamada:");
            foreach (Llamada llamada in Llamadas)
            {
                sb.AppendLine($"{llamada.ToString()}");
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            Llamadas.Add(nuevaLlamada);
        }

        public bool Guardar()
        {
            StreamWriter sw = new StreamWriter(this.RutaDeArchivo, true, Encoding.UTF8);
            sw.WriteLine($"{DateTime.Now.ToString($"dddd dd 'de' MMMM 'de' yyyy HH:MM'hs'")} - Se realizo una llamada");
            sw.Close();
            return true;
        }

        public string Leer()
        {
            string retorno = String.Empty;
            StreamReader sr = new StreamReader(this.RutaDeArchivo);
            retorno = (string)sr.ReadToEnd();
            sr.Close();
            return retorno;
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada l in c.Llamadas)
            {
                if (l == llamada)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {

            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
                try
                {
                    c.Guardar();
                    if(nuevaLlamada is Local)
                    {
                        ((Local)nuevaLlamada).Guardar();
                    }else if(nuevaLlamada is Provincial)
                    {
                        ((Provincial)nuevaLlamada).Guardar();
                    }
                    else
                    {
                        throw new InvalidCastException();
                    }
                }
                catch (Exception e)
                {
                    throw new FallaLogException("Error al guardar", e);
                }
                return c;
            }
            else
            {
                throw new CentralitaException("No se agregó la llamada", "Clase: Centralita", "Método: Sobrecarga operador +");
            }
        }

    }
}
