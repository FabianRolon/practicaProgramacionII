using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            :base(apellido, documento, nombre)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.anio}º{this.division}");
                return sb.ToString();
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ExponerDatos()}");
            sb.AppendLine($"{this.AnioDivision}");
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            //Metodo viejo largo como la mía
            #region Metodo viejo
            //Metodo largo, queda de recuerdo.
            /*bool retorno = false;
            if (doc.Length == 9 && !(doc is null))
            {
                if (doc[2] == '-' && doc[7] == '-')
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if ((int)doc[i] >= 48 && (int)doc[i] <= 57)
                        {
                            retorno = true;
                        }
                        else
                        {
                            retorno = false;
                            break;
                        }
                    }
                    if (retorno)
                    {
                        for (int i = 3; i < 7; i++)
                        {
                            if ((int)doc[i] >= 48 && (int)doc[i] <= 57)
                            {
                                retorno = true;
                            }
                            else
                            {
                                retorno = false;
                                break;
                            }
                        }
                    }
                    if (retorno)
                    {
                        if ((int)doc[8] <= 57 && (int)doc[8] >= 48)
                        {
                            retorno = true;
                        }
                        else
                        {
                            retorno = false;
                        }
                    }
                }
            }
            return retorno;*/
            #endregion 
            //Metodo corto optimizado
            bool retorno = false;
            if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')
            {
                foreach (char c in doc)
                {
                    if (!(char.IsDigit(c) || c == '-'))
                    {
                        return retorno;
                    }
                }
                retorno = true;
            }
            return retorno;
        }
    }
}
