using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        public PuntoDat()
        {

        }
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
            if (ValidarArchivo(ruta, true))
            {
                FileStream st = new FileStream(ruta, FileMode.Create); //dialogo.FileName es la ruta completa donde se eligio guardar, FileMode.Create crea el archivo o lo reemplaza si ya existe
                BinaryFormatter binfor = new BinaryFormatter(); //permite hacer la serializacion
                binfor.Serialize(st, objeto); //Se le pasa a la instacia de binnaryFormatter el stream creado y el objeto a serializar
                st.Close(); 
            }
            return true;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            if (ValidarArchivo(ruta, false))
            {
                FileStream st = new FileStream(ruta, FileMode.Create); //dialogo.FileName es la ruta completa donde se eligio guardar, FileMode.Create crea el archivo o lo reemplaza si ya existe
                BinaryFormatter binfor = new BinaryFormatter(); //permite hacer la serializacion
                binfor.Serialize(st, objeto); //Se le pasa a la instacia de binnaryFormatter el stream creado y el objeto a serializar
                st.Close();
            }
            return true;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat puntoDat = new PuntoDat();
            if (ValidarArchivo(ruta, true))
            {

                FileStream st = new FileStream(ruta, FileMode.Open); //dialogo.FileName es la ruta completa donde se eligio guardar, FileMode.Open indica que tiene que abrir el archivo  
                BinaryFormatter binfor = new BinaryFormatter(); //permite hacer la serializacion o deserialiacion
                puntoDat = (PuntoDat)binfor.Deserialize(st); //se crea una instancia del objeto a deserializar para que lo cargue
                st.Close();
            }
            return puntoDat;
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
            return true;
        }
    }
}
