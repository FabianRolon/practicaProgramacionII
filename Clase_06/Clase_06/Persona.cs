using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    public class Persona
    {
        string nombre;
        string apellido;
        int dni;
        /*bool vitalidad;
        string genero;
        string provincia;*/

        public Persona(string nombre, string apellido, int dni)/*, string genero, string provincia, bool vive)*/
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            /*this.genero = genero;
            this.provincia = provincia;
            this.vitalidad = vive;*/
        }
        
        public string Mostrar()
        {
            return this.nombre +" "+ this.apellido + " " + this.dni/* + " " +this.genero + " " +this.provincia + " " +this.vitalidad.ToString()*/;
        }
    }


}
