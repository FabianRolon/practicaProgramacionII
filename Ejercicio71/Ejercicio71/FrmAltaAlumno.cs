using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;

namespace Ejercicio69
{
    public partial class FrmAltaAlumno : Form
    {
        Alumno alumno;
        string ruta;
        public event DelegadoAlumno ActualizarAlumno;
        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void lblFoto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog cargarFoto = new OpenFileDialog();
            if(cargarFoto.ShowDialog() == DialogResult.OK)
            {
                ruta = cargarFoto.FileName;
                txtFoto.Text = ruta;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            alumno = new Alumno(txtNombre.Text, txtApellido.Text, ruta, int.Parse(txtDni.Text));
            if (ActualizarAlumno != null)
            {
                ActualizarAlumno.Invoke(alumno);
            }
        }
    }
}
