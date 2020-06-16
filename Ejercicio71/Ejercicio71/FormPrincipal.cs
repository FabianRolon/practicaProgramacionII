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
    public partial class FormPrincipal : Form
    {
        FrmTestDelegados frmTestDelegados;
        FrmMostrar frmMostrar;
        FrmAltaAlumno frmAltaAlumno;
        FrmDatosAlumnos frmDatos;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados = new FrmTestDelegados();
            frmTestDelegados.MdiParent = this;
            frmTestDelegados.Visible = true;
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            frmTestDelegados.ActualizarEtiqueta += frmMostrar.ActualizarNombre;
            frmTestDelegados.ActualizarImagen += frmMostrar.ActualizarFoto;
            frmMostrar.Visible = true;
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno = new FrmAltaAlumno();
            frmAltaAlumno.MdiParent = this;
            frmAltaAlumno.Visible = true;
            datosAlumnosToolStripMenuItem.Enabled = true;
        }

        private void datosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos = new FrmDatosAlumnos();
            frmDatos.MdiParent = this;
            frmAltaAlumno.ActualizarAlumno += frmDatos.InstanciarAlumno;
            frmDatos.Visible = true;
        }
    }
}
