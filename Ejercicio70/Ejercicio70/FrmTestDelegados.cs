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
    public partial class FrmTestDelegados : Form
    {
        FrmMostrar frmMostrar;
        string ruta;
        public event DelegadoMostrarManejador ActualizarEtiqueta;
        public event DelegadoMostrarManejador ActualizarImagen;
        public FrmTestDelegados()
        {
            abrirArchivo = new OpenFileDialog();
            abrirArchivo.InitialDirectory = @"C:\Users\alnil\Pictures\";
            frmMostrar = new FrmMostrar();
            InitializeComponent();
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
           if(abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                ruta = abrirArchivo.FileName; 
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ActualizarEtiqueta != null)
                ActualizarEtiqueta.Invoke(txtEtiqueta.Text);
            if (ActualizarImagen != null)
                ActualizarImagen.Invoke(ruta);
        }
    }
}
