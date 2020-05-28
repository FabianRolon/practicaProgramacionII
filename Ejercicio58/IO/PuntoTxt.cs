using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if (validaExistencia)
            {
                try
                {
                    if (base.ValidarArchivo(ruta, validaExistencia) && Path.GetExtension(ruta) == ".txt")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es .txt");
                    }
                }
                catch (FileNotFoundException ex)
                {
                    throw new ArchivoIncorrectoException("El archivo no es correcto", ex);
                }
            }
            return false;
        }
        public bool Guardar(string ruta, string objeto)
        {
            if (File.Exists(ruta))
            {
                StreamWriter writer = new StreamWriter(ruta);
                writer.Write(objeto);
                writer.Close();
                return true;
            }
            else
            {
                GuardarComo(ruta, objeto);
                return true;
            }
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            if (ValidarArchivo(ruta, true))
            {
                StreamWriter writer = new StreamWriter(ruta);
                writer.Write(objeto);
                writer.Close();
                return true; 
            }
            return false;
        }

        public string Leer(string ruta)
        {
            if (File.Exists(ruta))
            {
                StreamReader reader = new StreamReader(ruta);
                return reader.ReadToEnd();
            }
            return String.Empty;
        }
    }
}
