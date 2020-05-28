using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            throw new NotImplementedException();
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            throw new NotImplementedException();
        }

        public PuntoDat Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if (validaExistencia)
            {
                try
                {
                    if (base.ValidarArchivo(ruta, validaExistencia) && Path.GetExtension(ruta) == ".dat")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es .dat");
                    }
                }
                catch (FileNotFoundException ex)
                {
                    throw new ArchivoIncorrectoException("El archivo no es correcto", ex);
                }
            }
            return false;
        }
    }
}
