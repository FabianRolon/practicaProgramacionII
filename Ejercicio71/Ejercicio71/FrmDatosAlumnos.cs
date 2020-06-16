using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercicio69
{
    public delegate void DelegadoAlumno(Alumno alumno);
    public partial class FrmDatosAlumnos : FrmAltaAlumno
    {
        Alumno alumno;
        public FrmDatosAlumnos()
        {
            InitializeComponent();
        }
        public void InstanciarAlumno(Alumno a)
        {
            alumno = a;
            txtNombre.Text = a.Nombre;
            txtApellido.Text = a.Apellido;
            txtDni.Text = a.Dni.ToString();
            pbFotoAlumno.ImageLocation = a.RutaDeLaFoto;
            txtFoto.Text = a.RutaDeLaFoto;
        }
    }
}
