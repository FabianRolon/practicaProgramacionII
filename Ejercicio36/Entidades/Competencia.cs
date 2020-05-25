using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private TipoCompetencia tipo;
        private List<VehiculoDeCarrera> competidores;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public List<VehiculoDeCarrera> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {

              switch (c.Tipo)
              {
                   case TipoCompetencia.F1:
                    {
                        if (a is AutoF1)
                        {
                            return true;
                        }
                        else
                        {
                            throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Sobrecarga el ==");
                        }
                    }
                   case TipoCompetencia.MotoCross:
                    {
                        if (a is MotoCross)
                        {
                            return true;
                        }
                        else
                        {
                            throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Sobrecarga el ==");
                        }
                    }
                default:
                    return false;
              }
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo Competencia: {this.Tipo}");
            sb.AppendLine($"Cantidad de competidores: {this.CantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.CantidadVueltas}");
            sb.AppendLine($"Competidores:");
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                sb.AppendLine($"{vehiculo.MostrarDatos()}");
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            Random combustible = new Random();

            try
            {
                if (c == a && c.CantidadCompetidores > c.competidores.Count)
                {
                    foreach (VehiculoDeCarrera vehiculo in c.competidores)
                    {
                        if (vehiculo == a)
                            return false;
                    }
                    a.EnCompetencia = true;
                    a.CantidadCombustible = (short)combustible.Next(15, 100);
                    a.VueltasRestantes = c.CantidadVueltas;
                    c.competidores.Add(a);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            { 
                throw new CompetenciaNoDisponibleException("Competencia Incorrecta", "Competencia", "Sobrecarga de +", ex);
            }
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            foreach (VehiculoDeCarrera competidor in c.Competidores)
            {
                if(a == competidor)
                {
                    c.Competidores.Remove(competidor);
                    return true;
                }
            }
            return false;
        }
    }
}
